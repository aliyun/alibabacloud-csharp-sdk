// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Patch")]
        [Validation(Required=false)]
        public UpdateCloudAppInfoRequestPatch Patch { get; set; }
        public class UpdateCloudAppInfoRequestPatch : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://test_host/app/test-tar-pkg.tar">https://test_host/app/test-tar-pkg.tar</a></para>
            /// </summary>
            [NameInMap("DownloadURL")]
            [Validation(Required=false)]
            public string DownloadURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>346f6404395adfg5bae1e45g4e943bf7</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p1</para>
            /// </summary>
            [NameInMap("PatchName")]
            [Validation(Required=false)]
            public string PatchName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
