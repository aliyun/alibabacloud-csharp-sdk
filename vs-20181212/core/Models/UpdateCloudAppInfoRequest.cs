// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The cloud application ID, which corresponds to a unique application package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For testing purposes</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the patch package to upload.</para>
        /// <ol>
        /// <item><description>Not supported when PkgType is set to android.</description></item>
        /// <item><description>Only one patch can be in the uploading state at a time for the same AppId (only one patch in a non-final state is allowed per AppId).</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public UpdateCloudAppInfoRequestPatch Patch { get; set; }
        public class UpdateCloudAppInfoRequestPatch : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically set the patch as the stable patch after a successful upload. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AsStablePatch")]
            [Validation(Required=false)]
            public bool? AsStablePatch { get; set; }

            /// <summary>
            /// <para>The download URL of the patch package.
            /// Either RenderingInstanceId or DownloadURL is required. DownloadURL takes priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test_host/app/test-tar-pkg.tar">https://test_host/app/test-tar-pkg.tar</a></para>
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the patch package, used for integrity verification. Valid only when DownloadURL is not empty. Required when DownloadURL is not empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346f6404395adfg5bae1e45g4e943bf7</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name or description of the patch package, which serves as a unique identifier under the AppId.
            /// Naming conventions:</para>
            /// <ol>
            /// <item><description>Cannot be set to origin or all.</description></item>
            /// <item><description>Must be 1 to 50 characters in length.</description></item>
            /// <item><description>Can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
            /// <item><description>Must start and end with a letter or digit.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>p1</para>
            /// </summary>
            [NameInMap("PatchName")]
            [Validation(Required=false)]
            public string PatchName { get; set; }

            /// <summary>
            /// <para>The format of the installation package. The default value is the file extension of the download URL. Valid only when DownloadURL is not empty. Valid values:</para>
            /// <ol>
            /// <item><description>tar.gz</description></item>
            /// <item><description>tar</description></item>
            /// <item><description>zip</description></item>
            /// <item><description>rar</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>tar</para>
            /// </summary>
            [NameInMap("PkgFormat")]
            [Validation(Required=false)]
            public string PkgFormat { get; set; }

            /// <summary>
            /// <para>The relative path of the post-command within the application package. Only supported for Windows applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>install.ps1</para>
            /// </summary>
            [NameInMap("PostCommandPath")]
            [Validation(Required=false)]
            public string PostCommandPath { get; set; }

            /// <summary>
            /// <para>The timeout period for the post-command execution, in seconds. Only supported for Windows applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostCommandTimeoutSec")]
            [Validation(Required=false)]
            public int? PostCommandTimeoutSec { get; set; }

            /// <summary>
            /// <para>The instance ID of the instance used to create the patch package. Valid only for Android application marketplace scenarios (PkgType=andrpid_appmarket). Either RenderingInstanceId or DownloadURL is required. DownloadURL takes priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-d7ec79fe47ce47aca2d8d7500d25a28a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The cloud application labels. You can select multiple labels. This operation resets the cloud application labels.</para>
        /// <ol>
        /// <item><description>Valid values:
        ///   a. hot
        ///   b. game
        ///   c. app</description></item>
        /// <item><description>Special cases:
        ///   a. To delete all labels, set this parameter to [&quot;NULL&quot;].</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public List<string> PkgLabels { get; set; }

        /// <summary>
        /// <para>The stable PatchId. When a PatchId is not specified during business operations (such as session startup), this PatchId is used by default. Not supported when PkgType is set to android.
        /// Special values:</para>
        /// <ol>
        /// <item><description>origin: cancels the patch version and uses the initial version by default.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
