// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchAddressGroupsRequest : TeaModel {
        /// <summary>
        /// The level of the location.
        /// 
        /// Valid values:
        /// 
        /// *   country
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   province
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   city
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   district
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   township
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("address_level")]
        [Validation(Required=false)]
        public string AddressLevel { get; set; }

        /// <summary>
        /// The locations.
        /// </summary>
        [NameInMap("address_names")]
        [Validation(Required=false)]
        public List<string> AddressNames { get; set; }

        /// <summary>
        /// The coordinates of the bottom right vertex of the rectangle. Set the value in the format of latitude,longitude.
        /// </summary>
        [NameInMap("br_geo_point")]
        [Validation(Required=false)]
        public string BrGeoPoint { get; set; }

        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The method used to generate the thumbnail of an image.
        /// </summary>
        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        /// <summary>
        /// The coordinates of the top left vertex of the rectangle. Set the value in the format of latitude,longitude.
        /// </summary>
        [NameInMap("tl_geo_point")]
        [Validation(Required=false)]
        public string TlGeoPoint { get; set; }

        /// <summary>
        /// The method used to generate the thumbnail of a video.
        /// </summary>
        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
