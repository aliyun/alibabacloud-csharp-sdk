// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchAddressGroupsRequest : TeaModel {
        [NameInMap("address_level")]
        [Validation(Required=false)]
        public string AddressLevel { get; set; }

        [NameInMap("address_names")]
        [Validation(Required=false)]
        public List<string> AddressNames { get; set; }

        [NameInMap("br_geo_point")]
        [Validation(Required=false)]
        public string BrGeoPoint { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        [NameInMap("tl_geo_point")]
        [Validation(Required=false)]
        public string TlGeoPoint { get; set; }

        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
