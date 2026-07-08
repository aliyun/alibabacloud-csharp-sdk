// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("ClusterInfos")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudClustersResponseBodyClusterInfos> ClusterInfos { get; set; }
        public class DescribeHybridCloudClustersResponseBodyClusterInfos : TeaModel {
            /// <summary>
            /// <para>The network access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>internet</b>: Internet access.</para>
            /// </description></item>
            /// <item><description><para><b>vpc</b>: leased line-based private network access.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            /// <summary>
            /// <para>The region where the leased line is connected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn-hangzhou</b>: Hangzhou</para>
            /// </description></item>
            /// <item><description><para><b>cn-beijing</b>: Beijing</para>
            /// </description></item>
            /// <item><description><para><b>cn-shanghai</b>: Shanghai</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AccessRegion")]
            [Validation(Required=false)]
            public string AccessRegion { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testcluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The resource ID of the hybrid cloud cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdbc-cluster-t1****a</para>
            /// </summary>
            [NameInMap("ClusterResourceId")]
            [Validation(Required=false)]
            public string ClusterResourceId { get; set; }

            /// <summary>
            /// <para>The ports that use the HTTP protocol. The value is a string. If multiple ports are returned, they are separated by commas in the <b>port1,port2,port3</b> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,8080</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The ports that use the HTTPS protocol. The value is a string. If multiple ports are returned, they are separated by commas in the <b>port1,port2,port3</b> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443,8443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524**8</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of protection nodes that you can add to the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectionServerCount")]
            [Validation(Required=false)]
            public int? ProtectionServerCount { get; set; }

            /// <summary>
            /// <para>The status of the proxy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cname</b>: reverse proxy cluster</para>
            /// </description></item>
            /// <item><description><para><b>service</b>: service cluster</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cname</para>
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The rule configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enable&quot;:true,&quot;param&quot;:{&quot;breaker&quot;:{&quot;duration&quot;:1,&quot;failed&quot;:1,&quot;recent_failed&quot;:1},&quot;disable_protect&quot;:false,&quot;max_request_body_len&quot;:1,&quot;timeout&quot;:1}}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <para>The status of the manual bypass setting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>bypass</b>: WAF does not perform security checks and allows traffic to pass through.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-ER12-WE34-23PO-301469*****E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
