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
        /// <para>Used for testing</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the patch package to be uploaded. 1. This parameter is not supported when PkgType is set to android. 2. Only one patch package can be in the uploading state (non-final state) for the same AppId at a time.</para>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public UpdateCloudAppInfoRequestPatch Patch { get; set; }
        public class UpdateCloudAppInfoRequestPatch : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically configure the patch as the stable patch after a successful upload. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AsStablePatch")]
            [Validation(Required=false)]
            public bool? AsStablePatch { get; set; }

            /// <summary>
            /// <para>The download URL of the patch package. By default, the format of the patch package is the same as that of the original cloud application package. You must specify either RenderingInstanceId or DownloadURL. DownloadURL takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test_host/app/test-tar-pkg.tar">https://test_host/app/test-tar-pkg.tar</a></para>
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the patch package, which is used to verify integrity. This parameter is valid and required only when DownloadURL is not empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346f6404395adfg5bae1e45g4e943bf7</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name or description of the patch package, which is one of the unique identifiers under the AppId. Naming conventions: 1. The value cannot be origin or all. 2. The length must be 1 to 50 characters. 3. The value can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.). 4. The first and last characters must be letters or digits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p1</para>
            /// </summary>
            [NameInMap("PatchName")]
            [Validation(Required=false)]
            public string PatchName { get; set; }

            /// <summary>
            /// <para>The format of the installation package. By default, the format is the same as the suffix of the download file URL. This parameter is valid only when DownloadURL is not empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>tar.gz</description></item>
            /// <item><description>tar</description></item>
            /// <item><description>zip</description></item>
            /// <item><description>rar</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tar</para>
            /// </summary>
            [NameInMap("PkgFormat")]
            [Validation(Required=false)]
            public string PkgFormat { get; set; }

            /// <summary>
            /// <para>The relative path of the post-command within the application package. This parameter is supported only for Windows applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>install.ps1</para>
            /// </summary>
            [NameInMap("PostCommandPath")]
            [Validation(Required=false)]
            public string PostCommandPath { get; set; }

            /// <summary>
            /// <para>The timeout period for executing the post-command, in seconds. This parameter is supported only for Windows applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostCommandTimeoutSec")]
            [Validation(Required=false)]
            public int? PostCommandTimeoutSec { get; set; }

            /// <summary>
            /// <para>The instance ID used to create the patch package. This parameter is valid only for Android application marketplace scenarios where PkgType is set to andrpid_appmarket. You must specify either RenderingInstanceId or DownloadURL. DownloadURL takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-d7ec79fe47ce47aca2d8d7500d25a28a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The tags of the cloud application. You can specify multiple tags to reset the cloud application tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hot</description></item>
        /// <item><description>game</description></item>
        /// <item><description>app
        /// To delete all tags, set the value to [&quot;NULL&quot;].</description></item>
        /// </list>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public List<string> PkgLabels { get; set; }

        /// <summary>
        /// <para>The ID of the stable patch. This is the default patch ID used in customer business scenarios, such as session startup, when no patch ID is specified. This parameter is not supported when PkgType is set to android. Special value: origin: cancels the patch version and uses the initial version by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
