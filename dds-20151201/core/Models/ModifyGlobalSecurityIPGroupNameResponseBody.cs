// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyGlobalSecurityIPGroupNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The global IP whitelist templates.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<ModifyGlobalSecurityIPGroupNameResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class ModifyGlobalSecurityIPGroupNameResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// <para>The IP addresses in the whitelist template.</para>
            /// <remarks>
            /// <para>Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP address whitelists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>222.70.197.187</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP whitelist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// <para>The ID of the IP whitelist template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-qiawi8ec1urcx9swoy37</para>
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
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
