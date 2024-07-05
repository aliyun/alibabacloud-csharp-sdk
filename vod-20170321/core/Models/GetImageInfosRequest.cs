// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfosRequest : TeaModel {
        /// <summary>
        /// The time when the image URL expires. Unit: seconds.
        /// 
        /// *   If the OutputType parameter is set to cdn:
        /// 
        ///     *   This parameter takes effect only if URL authentication is enabled. Otherwise, the image URL does not expire.
        ///     *   Minimum value: 1.
        ///     *   Maximum value: unlimited.
        ///     *   Default value: The default validity period that is specified in URL authentication is used.
        /// 
        /// *   If the OutputType parameter is set to oss:
        /// 
        ///     *   This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the image URL does not expire.
        ///     *   Minimum value: 1.
        ///     *   Maximum value: 2592000 (30 days). This limit is imposed to reduce security risks of the origin server.
        ///     *   Default value: 3600.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// The image IDs. Separate multiple IDs with commas (,). You can specify a maximum of 20 image IDs. You can use one of the following methods to obtain the image ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/) and choose Media Files > Images in the left-side navigation pane. This method is applicable to images that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of ImageId from the response to the [CreateUploadImage](https://help.aliyun.com/document_detail/436544.html) operation that you call to obtain the upload URL and credential.
        /// *   Obtain the value of ImageId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/436559.html) operation after you upload images.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

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
