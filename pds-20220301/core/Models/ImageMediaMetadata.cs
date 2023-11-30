// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageMediaMetadata : TeaModel {
        [NameInMap("address_line")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        [NameInMap("exif")]
        [Validation(Required=false)]
        public string Exif { get; set; }

        [NameInMap("faces_thumbnail")]
        [Validation(Required=false)]
        public List<FaceThumbnail> FacesThumbnail { get; set; }

        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("image_quality")]
        [Validation(Required=false)]
        public ImageQuality ImageQuality { get; set; }

        [NameInMap("image_tags")]
        [Validation(Required=false)]
        public List<SystemTag> ImageTags { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
