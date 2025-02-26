// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the webcam redirection feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>off</description></item>
        /// <item><description>on</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The read/write permissions on the clipboard.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>read: read-only.</description></item>
        /// <item><description>readwrite: ready and write.</description></item>
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
        /// <para>The file transfer policy of the Alibaba Cloud Workspace web client.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: File upload and download are supported.</description></item>
        /// <item><description>download: Only file download is supported.</description></item>
        /// <item><description>upload: Only file upload is supported.</description></item>
        /// <item><description>off: File upload or download is forbidden.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
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
        /// <item><description>off: read/write disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <para>Specifies whether to lock the resolution.</para>
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
        public ModifyPolicyGroupRequestNetRedirectPolicy NetRedirectPolicy { get; set; }
        public class ModifyPolicyGroupRequestNetRedirectPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to manually configure a custom proxy.</para>
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
            /// <para>Specifies whether to enable network redirection.</para>
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

        }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-4bi18ebi9tfjh****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultPolicyGroup</para>
        /// </summary>
        [NameInMap("PolicyGroupName")]
        [Validation(Required=false)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// <para>The height of the resolution. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The width of the resolution. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

    }

}
