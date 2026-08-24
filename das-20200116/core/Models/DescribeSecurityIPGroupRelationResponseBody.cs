// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSecurityIPGroupRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>ListResult<InstanceSSL></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecurityIPGroupRelationResponseBodyData Data { get; set; }
        public class DescribeSecurityIPGroupRelationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The global IP whitelist template information.</para>
            /// </summary>
            [NameInMap("GlobalSecurityIPGroupRel")]
            [Validation(Required=false)]
            public List<DescribeSecurityIPGroupRelationResponseBodyDataGlobalSecurityIPGroupRel> GlobalSecurityIPGroupRel { get; set; }
            public class DescribeSecurityIPGroupRelationResponseBodyDataGlobalSecurityIPGroupRel : TeaModel {
                /// <summary>
                /// <para>The IP addresses in the whitelist template.</para>
                /// <remarks>
                /// <para>Separate multiple IP addresses with commas (,). You can add up to 1,000 IP addresses or CIDR blocks across all IP whitelists.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.28/32</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <para>The name of the IP whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
                /// </summary>
                [NameInMap("GlobalIgName")]
                [Validation(Required=false)]
                public string GlobalIgName { get; set; }

                /// <summary>
                /// <para>The ID of the IP whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-1no2rzybnqcv0xxxxxx</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1jdv45i7l6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6D1C8EE-013C-541F-83EB-B13C8xxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
