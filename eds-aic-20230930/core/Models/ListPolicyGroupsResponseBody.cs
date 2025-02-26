// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ListPolicyGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policies.</para>
        /// </summary>
        [NameInMap("PolicyGroupModel")]
        [Validation(Required=false)]
        public List<ListPolicyGroupsResponseBodyPolicyGroupModel> PolicyGroupModel { get; set; }
        public class ListPolicyGroupsResponseBodyPolicyGroupModel : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the webcam redirection feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CameraRedirect")]
            [Validation(Required=false)]
            public string CameraRedirect { get; set; }

            /// <summary>
            /// <para>The read/write permissions on the clipboard.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: read-only.</description></item>
            /// <item><description>readwrite: read and write.</description></item>
            /// <item><description>off: read/write disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>readwrite</para>
            /// </summary>
            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-04 10:28:54</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The file transfer policy of the HTML5 client.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: File upload and download are supported.</description></item>
            /// <item><description>download: Only file download is supported.</description></item>
            /// <item><description>upload: Only file upload is supported.</description></item>
            /// <item><description>off: File upload or download is forbidden.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>download</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>The read/write permissions on the on-premises drive.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>read: read-only.</description></item>
            /// <item><description>readwrite: ready and write.</description></item>
            /// <item><description>off: read/write denied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

            /// <summary>
            /// <para>Identifies whether the resolution is locked.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LockResolution")]
            [Validation(Required=false)]
            public string LockResolution { get; set; }

            /// <summary>
            /// <para>The network redirection policy.</para>
            /// </summary>
            [NameInMap("NetRedirectPolicy")]
            [Validation(Required=false)]
            public ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy NetRedirectPolicy { get; set; }
            public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether a custom proxy is manually configured.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>off</description></item>
                /// <item><description>on</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("CustomProxy")]
                [Validation(Required=false)]
                public string CustomProxy { get; set; }

                /// <summary>
                /// <para>The IPv4 address of the custom proxy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.100.XX.XX</para>
                /// </summary>
                [NameInMap("HostAddr")]
                [Validation(Required=false)]
                public string HostAddr { get; set; }

                /// <summary>
                /// <para>Indicates whether the network redirection feature is enabled. When this feature is enabled, network traffic is automatically redirected to the on-premises network by default.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>off</description></item>
                /// <item><description>on</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("NetRedirect")]
                [Validation(Required=false)]
                public string NetRedirect { get; set; }

                /// <summary>
                /// <para>The port of the custom proxy. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1145</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The password of the proxy. The password must be 1 to 256 in length and cannot contain Chinese character or space characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }

                /// <summary>
                /// <para>The type of the proxy protocol.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>socks5.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>socks5</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

                /// <summary>
                /// <para>The username of the proxy. The name must be 1 to 256 in length and cannot contain Chinese character or space characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("ProxyUserName")]
                [Validation(Required=false)]
                public string ProxyUserName { get; set; }

                /// <summary>
                /// <para>The proxy rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicyRules> Rules { get; set; }
                public class ListPolicyGroupsResponseBodyPolicyGroupModelNetRedirectPolicyRules : TeaModel {
                    /// <summary>
                    /// <para>The type of the rule.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>prc: an application package name.</description></item>
                    /// <item><description>domain: a domain name.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    /// <summary>
                    /// <para>The name of the application package or domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>*.example.com</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9q6o8qpiy8opkj****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default Policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The height of the resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <para>The width of the resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B9EFA4F-4305-5968-BAEE-BD8B8DE5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
