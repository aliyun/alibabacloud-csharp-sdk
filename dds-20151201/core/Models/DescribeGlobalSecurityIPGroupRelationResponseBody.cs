// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeGlobalSecurityIPGroupRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2ze6069764423m0l</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The global IP whitelist templates associated with the instance.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroupRel")]
        [Validation(Required=false)]
        public List<DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel> GlobalSecurityIPGroupRel { get; set; }
        public class DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel : TeaModel {
            /// <summary>
            /// <para>The IP addresses in the whitelist template.</para>
            /// <remarks>
            /// <para> Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP whitelists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>27.16.214.10,111.60.117.181</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP whitelist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_baoxian_k8s_bj</para>
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// <para>The ID of the IP whitelist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-gfurfpsh4ycbrm2avst7</para>
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8CA8312-530A-413A-9129-F2BB32A8D404</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
