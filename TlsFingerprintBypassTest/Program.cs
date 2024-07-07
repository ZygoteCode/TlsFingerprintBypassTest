using HttpTwo;

public class Program
{
    public static void Main()
    {
        Http2Client client = new Http2Client(new Http2ConnectionSettings("tls.browserleaks.com", 443, true));
        System.Collections.Specialized.NameValueCollection headers = new System.Collections.Specialized.NameValueCollection();

        headers.Add("host", "tls.browserleaks.com");
        headers.Add("sec-ch-ua", "\"Not/A)Brand\";v=\"8\", \"Chromium\";v=\"126\", \"Google Chrome\";v=\"126\"");
        headers.Add("sec-ch-ua-mobile", "?0");
        headers.Add("sec-ch-ua-platform", "\"Windows\"");
        headers.Add("upgrade-insecure-requests", "1");
        headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36");
        headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
        headers.Add("sec-fetch-site", "none");
        headers.Add("sec-fetch-mode", "navigate");
        headers.Add("sec-fetch-user", "?1");
        headers.Add("sec-fetch-dest", "document");
        headers.Add("accept-language", "it-IT,it;q=0.9,en-US;q=0.8,en;q=0.7");

        byte[] data = new byte[0] { };
        Http2Client.Http2Response response = client.Send(new Uri("https://tls.browserleaks.com/json"), HttpMethod.Get, headers, data)
            .GetAwaiter().GetResult();
        Console.WriteLine(System.Text.Encoding.UTF8.GetString(response.Body));
        Console.ReadLine();
    }
}