// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class RegisterPhotoRequest : TeaModel {
        [NameInMap("TakenAt")]
        [Validation(Required=false)]
        public long? TakenAt { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public float? Latitude { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public float? Longitude { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("IsVideo")]
        [Validation(Required=false)]
        public string IsVideo { get; set; }

        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("PhotoTitle")]
        [Validation(Required=false)]
        public string PhotoTitle { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
