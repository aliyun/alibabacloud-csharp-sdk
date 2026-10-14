// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7RsPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website whose forwarding rules you want to manage.</para>
        /// <remarks>
        /// <para>The domain name must have website forwarding rules configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names that have website forwarding rules configured.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The back-to-origin policy. The value is a character string that represents a JSON structure. The JSON structure contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>ProxyMode</b>: String | Required | The load balancing algorithm for back-to-origin. Valid values:<list type="bullet">
        /// <item><description><b>ip_hash</b>: IP Hash algorithm. Requests from the same source IP address are directed to the same origin server based on hash mapping.</description></item>
        /// <item><description><b>rr</b>: Polling algorithm. All requests are allocated to different origin servers in turn. When you use this algorithm, you can set weights for servers based on their performance.</description></item>
        /// <item><description><b>least_time</b>: Least Time algorithm. This algorithm uses intelligent DNS resolution to ensure the lowest latency for service traffic across the entire path from the protection node to forward back to the origin server.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Attributes</b>: JSONArray | Optional | The back-to-origin parameter information. Each element in the array contains the following fields:<list type="bullet">
        /// <item><description><b>RealServer</b>: String | Optional | The address of the origin server.</description></item>
        /// <item><description><b>Attribute</b>: JSONObject | Optional | The back-to-origin parameters. This field contains the following fields:<list type="bullet">
        /// <item><description><b>Weight</b>: Integer | Optional | The weight of the server. This property takes effect only when the polling algorithm is used (<b>ProxyMode</b> is set to <b>rr</b>). Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>. A server with a higher weight receives more requests.</description></item>
        /// <item><description><b>ConnectTimeout</b>: Integer | Optional | The timeout period for new connections. Valid values: <b>1</b> to <b>10</b>. Unit: seconds. Default value: <b>5</b>.</description></item>
        /// <item><description><b>FailTimeout</b>: Integer | Optional | The failed timeout period. Valid values: <b>1</b> to <b>3600</b>. Unit: seconds. Default value: <b>10</b>.</description></item>
        /// <item><description><b>MaxFails</b>: Integer | Optional | The maximum number of failures for health checks. Valid values: <b>1</b> to <b>10</b>. Default value: <b>3</b>.</description></item>
        /// <item><description><b>Mode</b>: String | Optional | The primary/secondary property flag. Valid values: <b>active</b> indicates primary. <b>backup</b> indicates secondary.</description></item>
        /// <item><description><b>ReadTimeout</b>: Integer | Optional | The read timeout period. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</description></item>
        /// <item><description><b>SendTimeout</b>: Integer | Optional | The write timeout period. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProxyMode&quot;:&quot;rr&quot;,&quot;Attributes&quot;:[{&quot;RealServer&quot;:&quot;1.<em><b>.</b></em>.1&quot;,&quot;Attribute&quot;:{&quot;Weight&quot;:100,&quot;ConnectTimeout&quot;:5,&quot;FailTimeout&quot;:10,&quot;MaxFails&quot;:3,&quot;Mode&quot;:&quot;active&quot;,&quot;ReadTimeout&quot;:120,&quot;SendTimeout&quot;:120}},{&quot;RealServer&quot;:&quot;2.<em><b>.</b></em>.2&quot;,&quot;Attribute&quot;:{&quot;Weight&quot;:100,&quot;ConnectTimeout&quot;:5,&quot;FailTimeout&quot;:10,&quot;MaxFails&quot;:3,&quot;Mode&quot;:&quot;active&quot;,&quot;ReadTimeout&quot;:120,&quot;SendTimeout&quot;:120}}]}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable back-to-origin retry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UpstreamRetry")]
        [Validation(Required=false)]
        public int? UpstreamRetry { get; set; }

    }

}
