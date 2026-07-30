// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySecurityIPGroupResponseBody : TeaModel {
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
        public ModifySecurityIPGroupResponseBodyData Data { get; set; }
        public class ModifySecurityIPGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the cross-product whitelist template.</para>
            /// </summary>
            [NameInMap("GlobalSecurityIPGroup")]
            [Validation(Required=false)]
            public List<ModifySecurityIPGroupResponseBodyDataGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
            public class ModifySecurityIPGroupResponseBodyDataGlobalSecurityIPGroup : TeaModel {
                /// <summary>
                /// <para>The IP addresses in the whitelist template.</para>
                /// <remarks>
                /// <para>Separate multiple IP addresses with commas. All IP address whitelists support a combined total of 1,000 IP addresses or address segments.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist template.</para>
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
                /// <para>g-b1asblm5ae****</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// <para>Example: cn-hangzhou</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The IP type.</para>
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
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned, such as an error code.</para>
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
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
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
