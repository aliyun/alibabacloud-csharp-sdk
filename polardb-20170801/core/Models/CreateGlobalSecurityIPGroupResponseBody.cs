// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the global IP whitelist template.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// <para>The IP addresses in the whitelist template.</para>
            /// <remarks>
            /// <para>Separate multiple IP addresses with commas (,). You can add a total of up to 1,000 IP addresses or CIDR blocks to all IP whitelists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP whitelist template. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>It can contain lowercase letters, digits, and underscores (_).</para>
            /// </description></item>
            /// <item><description><para>It must start with a letter and end with a letter or digit.</para>
            /// </description></item>
            /// <item><description><para>It must be 2 to 120 characters in length.</para>
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
            /// <para>The ID of the IP whitelist template.</para>
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
