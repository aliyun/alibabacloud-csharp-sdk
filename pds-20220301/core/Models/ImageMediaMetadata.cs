// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageMediaMetadata : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省杭州市滨江区西兴街道江陵路</para>
        /// </summary>
        [NameInMap("address_line")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>滨江区</para>
        /// </summary>
        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Compression&quot;:{&quot;value&quot;:&quot;6&quot;},&quot;DateTime&quot;:{&quot;value&quot;:&quot;2020:08:19 17:11:11&quot;}}</para>
        /// </summary>
        [NameInMap("exif")]
        [Validation(Required=false)]
        public string Exif { get; set; }

        [NameInMap("faces_thumbnail")]
        [Validation(Required=false)]
        public List<FaceThumbnail> FacesThumbnail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("image_quality")]
        [Validation(Required=false)]
        public ImageQuality ImageQuality { get; set; }

        [NameInMap("image_tags")]
        [Validation(Required=false)]
        public List<SystemTag> ImageTags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30.185453,120.218522</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05.000Z07:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>西兴街道</para>
        /// </summary>
        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
