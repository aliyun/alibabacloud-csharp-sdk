// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <para>**</para>
        /// <para><b>Description</b> The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The logs of the instant test tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\\&quot;redirectCount\\&quot;:0.0,\\&quot;SSLConnectTime\\&quot;:0.0,\\&quot;pingDetail\\&quot;:\\&quot;\\&quot;,\\&quot;HTTPConnectTime\\&quot;:0.0,\\&quot;isp\\&quot;:\\&quot;465\\&quot;,\\&quot;errorCode\\&quot;:611,\\&quot;ispCN\\&quot;:\\&quot;Alibaba\\&quot;,\\&quot;resolution\\&quot;:\\&quot;\\&quot;,\\&quot;areaEN\\&quot;:\\&quot;HuaBei\\&quot;,\\&quot;taskEndTimestamp\\&quot;:1638422475687,\\&quot;targetIspEN\\&quot;:\\&quot;\\&quot;,\\&quot;TotalTime\\&quot;:1.0,\\&quot;taskStartTimestamp\\&quot;:1638422474389,\\&quot;countryCN\\&quot;:\\&quot;China\\&quot;,\\&quot;provinceEN\\&quot;:\\&quot;Beijing\\&quot;,\\&quot;countryEN\\&quot;:\\&quot;China\\&quot;,\\&quot;targetCityEN\\&quot;:\\&quot;\\&quot;,\\&quot;curlConnectTime\\&quot;:0.0,\\&quot;ips\\&quot;:\\&quot;\\&quot;,\\&quot;route\\&quot;:\\&quot;\\&quot;,\\&quot;tcpConnectTime\\&quot;:0.0,\\&quot;cityEN\\&quot;:\\&quot;Beijing\\&quot;,\\&quot;HTTPDownloadSpeed\\&quot;:0.0,\\&quot;HTTPDownloadTime\\&quot;:0.0,\\&quot;HTTPResponseCode\\&quot;:0.0,\\&quot;areaCN\\&quot;:\\&quot;North China\\&quot;,\\&quot;city\\&quot;:\\&quot;546\\&quot;,\\&quot;expection\\&quot;:\\&quot;\\&quot;,\\&quot;suorceIp\\&quot;:\\&quot;192.168.XX.XX \\&quot;,\\&quot;ispEN\\&quot;:\\&quot;Alibaba\\&quot;,\\&quot;HTTPDNSTime\\&quot;:1.0,\\&quot;targetIsp\\&quot;:\\&quot;\\&quot;,\\&quot;curlStarttransferTime\\&quot;:0.0,\\&quot;provinceCN\\&quot;:\\&quot;Beijing\\&quot;,\\&quot;timestamp\\&quot;:1638422474000,\\&quot;redirectTime\\&quot;:0.0,\\&quot;targetCity\\&quot;:\\&quot;\\&quot;, \\&quot;expect\\&quot;:\\&quot;\\&quot;,\\&quot;HTTPDownloadSize\\&quot;:0.0,\\&quot;localDns\\&quot;:\\&quot;192.168.XX.XX\\&quot;,\\&quot;cityCN\\&quot;:\\&quot;Beijing\\&quot;,\\&quot;taskId\\&quot;:\\&quot;afa5c3ce-f944-4363-9edb-ce919a29\<em>\</em>\<em>\</em>\\&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F646FA-ED8A-58C2-B461-451DB52C8B14</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
