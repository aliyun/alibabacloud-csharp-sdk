// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP whitelist templates.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// <para>The IP addresses in the whitelist template.</para>
            /// <remarks>
            /// <para>Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP address whitelists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>111.207.194.217,61.149.7.154</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP whitelist template. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>It can contain lowercase letters, digits, and underscores (_).</description></item>
            /// <item><description>It must start with a letter and end with a letter or digit.</description></item>
            /// <item><description>It must be 2 to 120 characters in length.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>developer</para>
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// <para>The ID of the IP whitelist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-2ifynl1jfkdlhhxgva3q</para>
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
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
        /// <para>F8CA8312-530A-413A-9129-F2BB32A8D404</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
