// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyBundleRequest : TeaModel {
        /// <summary>
        /// The desktop template ID.
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The name of the new desktop template.
        /// </summary>
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// The description of the new desktop template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The new image ID. The new image must meet the following conditions:
        /// 
        /// *   The new image must be in the Available state.
        /// *   The operating system of the new image must be the same as that of the original image.
        /// *   The required disk size for the new image cannot be greater than that for the original image.
        /// *   The GPU type of the new image must be the same as that of the original image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The language of the OS. This parameter is available only for system images. Valid values:
        /// 
        /// *   zh-CN: Simplified Chinese
        /// *   zh-HK: Traditional Chinese (Hong Kong)
        /// *   en-US: English
        /// *   ja-JP: Japanese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
