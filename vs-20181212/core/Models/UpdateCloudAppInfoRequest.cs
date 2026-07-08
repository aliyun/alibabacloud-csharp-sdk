// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud application, which corresponds to a unique application package.</para>
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
        /// <para>用于测试使用</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Information about the patch package to upload.</para>
        /// <ol>
        /// <item><description><para>This parameter is not supported when PkgType is android.</para>
        /// </description></item>
        /// <item><description><para>For the same AppId, only one patch can be in the process of uploading at a time. This means only one patch can be in a state other than its desired state.</para>
        /// </description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public UpdateCloudAppInfoRequestPatch Patch { get; set; }
        public class UpdateCloudAppInfoRequestPatch : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically set the patch as the stable version after it is successfully uploaded. The default value is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AsStablePatch")]
            [Validation(Required=false)]
            public bool? AsStablePatch { get; set; }

            /// <summary>
            /// <para>The download URL for the patch package.
            /// You must specify either RenderingInstanceId or DownloadURL.
            /// DownloadURL takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test_host/app/test-tar-pkg.tar">https://test_host/app/test-tar-pkg.tar</a></para>
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the patch package, used to verify integrity. This parameter is valid only if DownloadURL is not empty. It is required if DownloadURL is not empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346f6404395adfg5bae1e45g4e943bf7</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name or description of the patch package. This is a unique identifier under the AppId.
            /// Default naming conventions:</para>
            /// <ol>
            /// <item><description><para>Cannot be origin or all.</para>
            /// </description></item>
            /// <item><description><para>Must be 1 to 50 characters in length.</para>
            /// </description></item>
            /// <item><description><para>Can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</para>
            /// </description></item>
            /// <item><description><para>The first and last characters must be a letter or a digit.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>p1</para>
            /// </summary>
            [NameInMap("PatchName")]
            [Validation(Required=false)]
            public string PatchName { get; set; }

            /// <summary>
            /// <para>The format of the installation package. By default, the system uses the file extension from the download URL. This parameter is valid only if DownloadURL is not empty. Valid values:</para>
            /// <ol>
            /// <item><description><para>tar.gz</para>
            /// </description></item>
            /// <item><description><para>tar</para>
            /// </description></item>
            /// <item><description><para>zip</para>
            /// </description></item>
            /// <item><description><para>rar</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>tar</para>
            /// </summary>
            [NameInMap("PkgFormat")]
            [Validation(Required=false)]
            public string PkgFormat { get; set; }

            /// <summary>
            /// <para>The instance ID required to create the patch package. This parameter is valid only in the Android application marketplace scenario (PkgType=andrpid_appmarket). Specify either RenderingInstanceId or DownloadURL. DownloadURL takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-d7ec79fe47ce47aca2d8d7500d25a28a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The tags for the cloud application. You can select multiple tags. This action resets all existing tags for the cloud application.</para>
        /// <ol>
        /// <item><description><para>Valid values:
        /// hot, game, and app.</para>
        /// </description></item>
        /// <item><description><para>Special case:
        /// To delete all tags, enter [&quot;NULL&quot;].</para>
        /// </description></item>
        /// </ol>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public List<string> PkgLabels { get; set; }

        /// <summary>
        /// <para>The ID of the stable patch. This patch is used by default if you do not specify a PatchId when the application is in use, such as during a session startup. This parameter is not supported when PkgType is android.
        /// Special value:</para>
        /// <ol>
        /// <item><description>If you set this parameter to origin, the patch version is removed and the initial version is used.</description></item>
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
