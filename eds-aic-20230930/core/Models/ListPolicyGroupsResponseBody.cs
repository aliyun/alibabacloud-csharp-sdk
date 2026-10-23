// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ListPolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that indicates the read position returned by the current call. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy information.</para>
        /// </summary>
        [NameInMap("PolicyGroupModel")]
        [Validation(Required=false)]
        public List<ListPolicyGroupsResponseBodyPolicyGroupModel> PolicyGroupModel { get; set; }
        public class ListPolicyGroupsResponseBodyPolicyGroupModel : TeaModel {
            /// <summary>
            /// <para>The list of access policy rules.</para>
            /// </summary>
            [NameInMap("AccessPolicies")]
            [Validation(Required=false)]
            public List<ListPolicyGroupsResponseBodyPolicyGroupModelAccessPolicies> AccessPolicies { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelAccessPolicies : TeaModel {
                /// <summary>
                /// <para>The access policy rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("AccessPolicyRuleId")]
                [Validation(Required=false)]
                public long? AccessPolicyRuleId { get; set; }

                /// <summary>
                /// <para>The CIDR IP address block to which the rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the access policy rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The access policy action. ALLOW indicates that access is allowed, and DENY indicates that access is denied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLOW</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The priority of the access policy rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether local camera redirection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// <para>The clipboard permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-04 10:28:54</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The HTML5 client file transfer policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>download</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>The local disk mapping permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>The locked resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LockResolution")]
            [Validation(Required=false)]
            public string LockResolution { get; set; }

            /// <summary>
            /// <para>The network redirection.</para>
            /// </summary>
            [NameInMap("NetRedirectPolicy")]
            [Validation(Required=false)]
            public ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy NetRedirectPolicy { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether a transparent proxy is manually configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("CustomProxy")]
                [Validation(Required=false)]
                public string CustomProxy { get; set; }

                /// <summary>
                /// <para>The transparent proxy IP address. The format is an IPv4 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX</para>
                /// </summary>
                [NameInMap("HostAddr")]
                [Validation(Required=false)]
                public string HostAddr { get; set; }

                /// <summary>
                /// <para>Indicates whether network redirection is enabled. If enabled, traffic is redirected to the client-side network by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("NetRedirect")]
                [Validation(Required=false)]
                public string NetRedirect { get; set; }

                /// <summary>
                /// <para>The transparent proxy port. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1145</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The proxy password. The length ranges from 1 to 256 characters. Chinese characters and whitespace characters are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }

                /// <summary>
                /// <para>The proxy protocol type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>socks5</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

                /// <summary>
                /// <para>The proxy username. The length ranges from 1 to 256 characters. Chinese characters and whitespace characters are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("ProxyUserName")]
                [Validation(Required=false)]
                public string ProxyUserName { get; set; }

                /// <summary>
                /// <para>The proxy rule list.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicyRules> Rules { get; set; }
                public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicyRules : TeaModel {
                    /// <summary>
                    /// <para>The rule type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    /// <summary>
                    /// <para>The application package name or domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>*.baidu.com</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

            }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9q6o8qpiy8opkj****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The resources associated with the policy.</para>
            /// </summary>
            [NameInMap("PolicyRelatedResources")]
            [Validation(Required=false)]
            public ListPolicyGroupsResponseBodyPolicyGroupModelPolicyRelatedResources PolicyRelatedResources { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelPolicyRelatedResources : TeaModel {
                /// <summary>
                /// <para>The list of instance group IDs.</para>
                /// </summary>
                [NameInMap("AndroidInstanceGroupIds")]
                [Validation(Required=false)]
                public List<string> AndroidInstanceGroupIds { get; set; }

                /// <summary>
                /// <para>The list of matrix IDs.</para>
                /// </summary>
                [NameInMap("CloudPhoneMatrixIds")]
                [Validation(Required=false)]
                public List<string> CloudPhoneMatrixIds { get; set; }

            }

            /// <summary>
            /// <para>The resolution height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <para>The resolution width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            /// <summary>
            /// <para>The screen watermark.</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public ListPolicyGroupsResponseBodyPolicyGroupModelWatermark Watermark { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelWatermark : TeaModel {
                /// <summary>
                /// <para>The watermark font color. Valid values: 0 to 16777215.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WatermarkColor")]
                [Validation(Required=false)]
                public int? WatermarkColor { get; set; }

                /// <summary>
                /// <para>The custom watermark content. The length cannot exceed 10 characters, and emoji characters are not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom text</para>
                /// </summary>
                [NameInMap("WatermarkCustomText")]
                [Validation(Required=false)]
                public string WatermarkCustomText { get; set; }

                /// <summary>
                /// <para>The watermark font size. Valid values: 10 to 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("WatermarkFontSize")]
                [Validation(Required=false)]
                public int? WatermarkFontSize { get; set; }

                /// <summary>
                /// <para>The screen watermark switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("WatermarkSwitch")]
                [Validation(Required=false)]
                public string WatermarkSwitch { get; set; }

                /// <summary>
                /// <para>The watermark opacity. A larger value indicates lower transparency. Valid values: 10 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("WatermarkTransparencyValue")]
                [Validation(Required=false)]
                public int? WatermarkTransparencyValue { get; set; }

                /// <summary>
                /// <para>The screen watermark content.</para>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B9EFA4F-4305-5968-BAEE-BD8B8DE5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
