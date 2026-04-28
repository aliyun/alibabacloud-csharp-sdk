// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageMediaMetadata : TeaModel {
        /// <summary>
        /// <para>The full address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jiangling Road, Xixing Street, Binjiang District, Hangzhou, Zhejiang</para>
        /// </summary>
        [NameInMap("address_line")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        /// <summary>
        /// <para>The city in which the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The country or region in which the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The district in which the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Binjiang District</para>
        /// </summary>
        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        /// <summary>
        /// <para>The EXIF information about the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Compression&quot;:{&quot;value&quot;:&quot;6&quot;},&quot;DateTime&quot;:{&quot;value&quot;:&quot;2020:08:19 17:11:11&quot;}}</para>
        /// </summary>
        [NameInMap("exif")]
        [Validation(Required=false)]
        public string Exif { get; set; }

        /// <summary>
        /// <para>The thumbnails of the faces.</para>
        /// </summary>
        [NameInMap("faces_thumbnail")]
        [Validation(Required=false)]
        public List<FaceThumbnail> FacesThumbnail { get; set; }

        /// <summary>
        /// <para>The height of the image. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// <para>The rating of the image.</para>
        /// </summary>
        [NameInMap("image_quality")]
        [Validation(Required=false)]
        public ImageQuality ImageQuality { get; set; }

        /// <summary>
        /// <para>The details of the image tags.</para>
        /// </summary>
        [NameInMap("image_tags")]
        [Validation(Required=false)]
        public List<SystemTag> ImageTags { get; set; }

        /// <summary>
        /// <para>The location of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30.185453,120.218522</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The province in which the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The time when the image was taken. The time follows the RFC3339 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05.000Z07:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The street in which the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xixing Street</para>
        /// </summary>
        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

        /// <summary>
        /// <para>The width of the image. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
