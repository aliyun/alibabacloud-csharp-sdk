// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfoRequest : TeaModel {
        /// <summary>
        /// The time when the image URL expires. Unit: seconds.
        /// 
        /// *   If you set OutputType to cdn:
        /// 
        ///     *   This parameter takes effect only if URL authentication is enabled. Otherwise, the image URL does not expire.
        ///     *   Minimum value: 1.
        ///     *   Maximum value: unlimited.
        ///     *   Default value: If you leave this parameter empty, the default validity period that is specified in URL signing is used.
        /// 
        /// *   If you set OutputType to oss:
        /// 
        ///     *   This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the image URL does not expire.
        ///     *   Minimum value: 1.
        ///     *   If you store the image in the VOD bucket, the maximum value of this parameter is **2592000** (30 days). If you store the image in an OSS bucket, the maximum value of this parameter is **129600** (36 hours). The maximum value is limited to reduce security risks of the origin.
        ///     *   Default value: 3600.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The ID of the image. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/). In the left-side navigation pane, choose Media Files > Image. On the Image page, view the image ID.
        /// *   Obtain the image ID from the response to the [CreateUploadImage](~~CreateUploadImage~~) operation that you call to obtain the upload URL and credential.
        /// *   Obtain the image ID from the response to the [SearchMedia](~~SearchMedia~~) operation that you call to query the image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the output image URL. Valid values:
        /// 
        /// *   oss: OSS URL
        /// *   cdn: CDN URL
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
