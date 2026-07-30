// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySecurityIPGroupRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifySecurityIPGroupRelationResponseBodyData Data { get; set; }
        public class ModifySecurityIPGroupRelationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the cross-product IP address whitelist template that is attached to the instance.</para>
            /// </summary>
            [NameInMap("GlobalSecurityIPGroupRel")]
            [Validation(Required=false)]
            public List<ModifySecurityIPGroupRelationResponseBodyDataGlobalSecurityIPGroupRel> GlobalSecurityIPGroupRel { get; set; }
            public class ModifySecurityIPGroupRelationResponseBodyDataGlobalSecurityIPGroupRel : TeaModel {
                /// <summary>
                /// <para>The IP addresses in the whitelist template.</para>
                /// <remarks>
                /// <para>Separate multiple IP addresses with commas (,). A maximum of 1,000 IP addresses or CIDR blocks can be added to all IP address whitelists.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1,192.168.100.0/24</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist template. The name must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description><para>It must consist of lowercase letters, digits, and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>It must start with a letter and end with a letter or a digit.</para>
                /// </description></item>
                /// <item><description><para>It must be 2 to 120 characters in length.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>saas_jump</para>
                /// </summary>
                [NameInMap("GlobalIgName")]
                [Validation(Required=false)]
                public string GlobalIgName { get; set; }

                /// <summary>
                /// <para>The ID of the IP address whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-v8kwereyd6u7kx****</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
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
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, Successful is returned. If the request fails, an error message, such as an error code, is returned.</para>
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
        /// <para>840F51F7-9C01-538D-94F6-AE712905****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
