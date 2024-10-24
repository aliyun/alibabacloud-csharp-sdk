// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7RsPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query the domain names for which forwarding rules are configured.</para>
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
        /// <para>The back-to-origin policy. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProxyMode</b>: The load balancing algorithm for back-to-origin traffic. This field is required and must be a string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip_hash</b>: the IP hash algorithm. This algorithm is used to redirect requests from the same IP address to the same origin server.</description></item>
        /// <item><description><b>rr</b>: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn. If you use this algorithm, you can specify a weight for each server based on server performance.</description></item>
        /// <item><description><b>least_time</b>: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from the instance to origin servers based on the intelligent DNS resolution feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Attributes</b>: the parameters for back-to-origin processing. This field is optional and must be a JSON array. Each element in the array contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RealServer</b>: the address of the origin server. This field is optional and must be a string.</para>
        /// </description></item>
        /// <item><description><para><b>Attribute</b>: the parameter for back-to-origin processing. This field is optional and must be a JSON object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Weight</b>: the weight of the server. This field is optional and must be an integer. This field takes effect only when <b>ProxyMode</b> is set to <b>rr</b>. Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>. An origin server with a higher weight receives more requests.</description></item>
        /// <item><description><b>ConnectTimeout</b>: the timeout period for new connections. This field is optional and must be an integer. Valid values: <b>1</b> to <b>10</b>. Unit: seconds. Default value: <b>5</b>.</description></item>
        /// <item><description><b>FailTimeout</b>: the period after which a connection is considered to have failed. This field is optional and must be an integer. Valid values: <b>1</b> to <b>3600</b>. Unit: seconds. Default value: <b>10</b>.</description></item>
        /// <item><description><b>MaxFails</b>: the maximum number of failures allowed. This field is related to health checks. This field is optional and must be an integer. Valid values: <b>1</b> to <b>10</b>. Unit: seconds. Default value: <b>3</b>.</description></item>
        /// <item><description><b>Mode</b>: the primary/secondary attribute flag. This parameter is optional and must be a string. Valid values: <b>active</b> (primary) and <b>backup</b> (secondary).</description></item>
        /// <item><description><b>ReadTimeout</b>: the read timeout period. This field is optional and must be an integer. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</description></item>
        /// <item><description><b>SendTimeout</b>: the write timeout period. This field is optional and must be an integer. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProxyMode&quot;:&quot;rr&quot;,&quot;Attributes&quot;:[{&quot;RealServer&quot;:&quot;1.<em><b>.</b></em>.1&quot;,&quot;Attribute&quot;:{&quot;Weight&quot;:100}},{&quot;RealServer&quot;:&quot;2.<em><b>.</b></em>.2&quot;,&quot;Attribute&quot;:{&quot;Weight&quot;:100}}]}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The retry switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: on</description></item>
        /// <item><description><b>0</b>: off</description></item>
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
