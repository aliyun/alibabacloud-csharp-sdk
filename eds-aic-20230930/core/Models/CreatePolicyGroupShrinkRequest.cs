// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreatePolicyGroupShrinkRequest : TeaModel {
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
        public string NetRedirectPolicyShrink { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultPolicy</para>
        /// </summary>
        [NameInMap("PolicyGroupName")]
        [Validation(Required=false)]
        public string PolicyGroupName { get; set; }

        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

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

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string WatermarkShrink { get; set; }

    }

}
