// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAllowedIpListResponseBody : TeaModel {
        /// <summary>
        /// <para>The allowlist.</para>
        /// </summary>
        [NameInMap("AllowedList")]
        [Validation(Required=false)]
        public GetAllowedIpListResponseBodyAllowedList AllowedList { get; set; }
        public class GetAllowedIpListResponseBodyAllowedList : TeaModel {
            /// <summary>
            /// <para>The deployment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: Internet/VPC</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: VPC</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This field is not relevant for regular users and is intended for integration partners.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public int? DeployType { get; set; }

            /// <summary>
            /// <para>The Internet allowlists.</para>
            /// </summary>
            [NameInMap("InternetList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListInternetList> InternetList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListInternetList : TeaModel {
                /// <summary>
                /// <para>The Internet IP address allowlist group.</para>
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// <para>The Internet IP address allowlists.</para>
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                /// <summary>
                /// <para>The Internet IP address blocklists.</para>
                /// </summary>
                [NameInMap("BlackIPList")]
                [Validation(Required=false)]
                public List<string> BlackIPList { get; set; }

                /// <summary>
                /// <para>The Internet IP address blocklist group.</para>
                /// </summary>
                [NameInMap("BlackIPMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlackIPMap { get; set; }

                /// <summary>
                /// <para>The port range. Valid values:</para>
                /// <para><b>9093/9093</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9093/9093</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2zea4atm7fvj**********</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether it is a shared security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserDefinedSharedSecurityGroup")]
                [Validation(Required=false)]
                public bool? UserDefinedSharedSecurityGroup { get; set; }

            }

            /// <summary>
            /// <para>The VPC allowlists.</para>
            /// </summary>
            [NameInMap("VpcList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListVpcList> VpcList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListVpcList : TeaModel {
                /// <summary>
                /// <para>The IP address allowlist group.</para>
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// <para>The IP address allowlists.</para>
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                /// <summary>
                /// <para>The IP address blocklists.</para>
                /// </summary>
                [NameInMap("BlackIPList")]
                [Validation(Required=false)]
                public List<string> BlackIPList { get; set; }

                /// <summary>
                /// <para>The IP address blocklist group.</para>
                /// </summary>
                [NameInMap("BlackIPMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlackIPMap { get; set; }

                /// <summary>
                /// <para>The port range. Valid values:</para>
                /// <para><b>9092/9092</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9092/9092</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2zea4atm7fvj**********</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether it is a shared security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserDefinedSharedSecurityGroup")]
                [Validation(Required=false)]
                public bool? UserDefinedSharedSecurityGroup { get; set; }

            }

        }

        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A421CCD7-5BC5-4B32-8DD8-64668A8FCB56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
