// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportImageRequest : TeaModel {
        /// <summary>
        /// The ID of the image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The OSS bucket to which you want to export the image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// The prefix of the object as which you want to store the image in the OSS bucket. The prefix must be 1 to 30 characters in length and can contain digits and letters.
        /// </summary>
        [NameInMap("OSSPrefix")]
        [Validation(Required=false)]
        public string OSSPrefix { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// Valid values:
        /// 
        /// *   cn-beijing
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OSSRegionId")]
        [Validation(Required=false)]
        public string OSSRegionId { get; set; }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
