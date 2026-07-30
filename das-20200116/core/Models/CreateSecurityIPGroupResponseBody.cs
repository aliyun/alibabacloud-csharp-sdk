// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSecurityIPGroupResponseBodyData Data { get; set; }
        public class CreateSecurityIPGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the cross-product whitelist template.</para>
            /// </summary>
            [NameInMap("GlobalSecurityIPGroup")]
            [Validation(Required=false)]
            public List<CreateSecurityIPGroupResponseBodyDataGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
            public class CreateSecurityIPGroupResponseBodyDataGlobalSecurityIPGroup : TeaModel {
                /// <summary>
                /// <para>The IP addresses in the whitelist template.</para>
                /// <remarks>
                /// <para>Separate multiple IP addresses with commas (,). A cumulative total of 1,000 IP addresses or CIDR blocks can be added to all IP address whitelists.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/24</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist template. The name must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description><para>Consists of lowercase letters, digits, and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>Starts with a letter and ends with a letter or a digit.</para>
                /// </description></item>
                /// <item><description><para>Is 2 to 120 characters in length.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GlobalIgName")]
                [Validation(Required=false)]
                public string GlobalIgName { get; set; }

                /// <summary>
                /// <para>The ID of the IP address whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-2uztsd6yvhmsqyjXXX</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// <para>Example: cn-hangzhou</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The IP address type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIpType")]
                [Validation(Required=false)]
                public string SecurityIpType { get; set; }

                /// <summary>
                /// <para>The network type of the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("WhitelistNetType")]
                [Validation(Required=false)]
                public string WhitelistNetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, Successful is returned. If the request fails, an error message is returned, such as an error code.</para>
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
        /// <para>D578DB3C-06BF-54F2-A78F-C6C25Exxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
