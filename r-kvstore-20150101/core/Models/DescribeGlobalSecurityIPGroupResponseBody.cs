// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP whitelist template information.</para>
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<DescribeGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class DescribeGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// <para>The instance IDs associated with the IP whitelist template.</para>
            /// </summary>
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<string> DBInstances { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist template.</para>
            /// <remarks>
            /// <para>Separate multiple IP addresses with commas (,).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1,10.10.10.10</para>
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// <para>The name of the IP whitelist template.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FF6158E-3394-4A90-B634-79C49184****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
