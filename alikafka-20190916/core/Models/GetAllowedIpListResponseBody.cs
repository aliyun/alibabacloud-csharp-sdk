// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAllowedIpListResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// </summary>
        [NameInMap("AllowedList")]
        [Validation(Required=false)]
        public GetAllowedIpListResponseBodyAllowedList AllowedList { get; set; }
        public class GetAllowedIpListResponseBodyAllowedList : TeaModel {
            /// <summary>
            /// <para>The deployment mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: allows access from the Internet and a virtual private cloud (VPC).</description></item>
            /// <item><description><b>5</b>: allows access from a VPC.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Only integrators need to concern themselves with the value of this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public int? DeployType { get; set; }

            /// <summary>
            /// <para>The whitelist for access from the Internet.</para>
            /// </summary>
            [NameInMap("InternetList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListInternetList> InternetList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListInternetList : TeaModel {
                /// <summary>
                /// <para>The group to which the IP address whitelist belongs.</para>
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// <para>The information about the IP address whitelist.</para>
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                [NameInMap("BlackIPList")]
                [Validation(Required=false)]
                public List<string> BlackIPList { get; set; }

                [NameInMap("BlackIPMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlackIPMap { get; set; }

                /// <summary>
                /// <para>The port range. Valid value:</para>
                /// <para><b>9093/9093</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9093/9093</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("UserDefinedSharedSecurityGroup")]
                [Validation(Required=false)]
                public bool? UserDefinedSharedSecurityGroup { get; set; }

            }

            /// <summary>
            /// <para>The whitelist for access from a virtual private cloud (VPC).</para>
            /// </summary>
            [NameInMap("VpcList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListVpcList> VpcList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListVpcList : TeaModel {
                /// <summary>
                /// <para>The group to which the IP address whitelist belongs.</para>
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// <para>The information about the IP address whitelist.</para>
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                [NameInMap("BlackIPList")]
                [Validation(Required=false)]
                public List<string> BlackIPList { get; set; }

                [NameInMap("BlackIPMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> BlackIPMap { get; set; }

                /// <summary>
                /// <para>The port range. Valid value:</para>
                /// <para><b>9092/9092</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9092/9092</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("UserDefinedSharedSecurityGroup")]
                [Validation(Required=false)]
                public bool? UserDefinedSharedSecurityGroup { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
