// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImAuditRequest : TeaModel {
        /// <summary>
        /// The business type. By default, the public business type is used.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// The custom text entries. You can specify up to 5 text entries. The value must be a JSON array. You must specify at least one of the Images and Contents parameters.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string Contents { get; set; }

        /// <summary>
        /// The image URLs. You can specify up to 5 image URLs. The value must be a JSON array. To view the URLs of the images, you can log on to the **ApsaraVideo Media Processing (MPS) console** and choose **Media Management** > **Media List** in the left-side navigation pane. You must set at least one of the Images and Contents parameters. The image to be moderated must meet the following limits. Otherwise, the moderation task may fail.
        /// 
        /// *   The image size cannot exceed 20 MB, the height or width of the image cannot exceed 30,000 pixels, and the image cannot exceed 0.25 billion pixels.
        /// *   We recommend that you upload images of at least 256 × 256 pixels to ensure required moderation result.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The moderation scenarios. Separate multiple scenarios with commas (,). For example, if you specify {"porn","terrorism"} for this parameter, both pornographic content detection and terrorist content detection are performed on the images and text. Valid values:
        /// 
        /// *   porn: pornography
        /// *   terrorism: terrorist content
        /// *   ad: ad violation
        /// *   qrcode: QR code
        /// *   live: undesirable scene
        /// *   logo: special logo
        /// *   antispam: text anti-spam (valid only for text)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

    }

}
