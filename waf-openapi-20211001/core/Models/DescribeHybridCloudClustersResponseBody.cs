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
            /// <item><description><b>internet</b>: Internet access.</description></item>
            /// <item><description><b>vpc</b>: Express Connect private network access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internet</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            /// <summary>
            /// <para>The Express Connect access region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn-hangzhou</b>: Hangzhou.</description></item>
            /// <item><description><b>cn-beiijng</b>: Beijing.</description></item>
            /// <item><description><b>cn-shanghai</b>: Shanghai.</description></item>
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
            /// <para>The list of HTTP ports. Separate multiple ports with commas (,). Example: port1,port2,port3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,8080</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The list of HTTPS ports. Separate multiple ports with commas (,). Example: port1,port2,port3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443,8443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524**8</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of protection nodes that can be added to the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectionServerCount")]
            [Validation(Required=false)]
            public int? ProtectionServerCount { get; set; }

            /// <summary>
            /// <para>The proxy gateway mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cname</b>: Reverse proxy cluster.</description></item>
            /// <item><description><b>service</b>: Service cluster.</description></item>
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
            /// <para>The manual bypass status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: Disabled.</para>
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
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>bypass</b>: Skips security checks and directly allows requests.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-ER12-WE34-23PO-301469*****E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
