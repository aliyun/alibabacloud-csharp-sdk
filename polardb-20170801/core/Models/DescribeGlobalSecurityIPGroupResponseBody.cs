// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the global IP allowlist template.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<DescribeGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class DescribeGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// <para>The list of clusters associated with the IP allowlist template.</para>
            /// </summary>
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<string> DBInstances { get; set; }

            /// <summary>
            /// <para>The IP addresses in the allowlist template.</para>
            /// <remarks>
            /// <para>Separate multiple IP addresses with commas (,). You can add up to 1,000 IP addresses or CIDR blocks to all IP allowlists in total.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP allowlist template. The name of the IP allowlist template must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The name can contain lowercase letters, digits, and underscores (_).</para>
            /// </description></item>
            /// <item><description><para>The name must start with a letter and end with a letter or a digit.</para>
            /// </description></item>
            /// <item><description><para>The name must be 2 to 120 characters in length.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test_123</para>
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// <para>The ID of the IP allowlist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-zsldxfiwjmti0kcm****</para>
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
