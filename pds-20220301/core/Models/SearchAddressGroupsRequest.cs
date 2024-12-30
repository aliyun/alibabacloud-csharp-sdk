// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchAddressGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The level of the location.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>country</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>province</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>city</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>district</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>township</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// </summary>
        [NameInMap("address_level")]
        [Validation(Required=false)]
        public string AddressLevel { get; set; }

        /// <summary>
        /// <para>The locations.</para>
        /// </summary>
        [NameInMap("address_names")]
        [Validation(Required=false)]
        public List<string> AddressNames { get; set; }

        /// <summary>
        /// <para>The coordinates of the bottom right vertex of the rectangle. Set the value in the format of latitude,longitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40.121,105.2121</para>
        /// </summary>
        [NameInMap("br_geo_point")]
        [Validation(Required=false)]
        public string BrGeoPoint { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The method used to generate the thumbnail of an image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,w_200</para>
        /// </summary>
        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        /// <summary>
        /// <para>The coordinates of the top left vertex of the rectangle. Set the value in the format of latitude,longitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.121,101.2121</para>
        /// </summary>
        [NameInMap("tl_geo_point")]
        [Validation(Required=false)]
        public string TlGeoPoint { get; set; }

        /// <summary>
        /// <para>The method used to generate the thumbnail of a video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast</para>
        /// </summary>
        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
