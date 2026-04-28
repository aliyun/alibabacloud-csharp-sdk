// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageTag : TeaModel {
        /// <summary>
        /// <para>The number of files in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The category of the cover image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("cover_file_category")]
        [Validation(Required=false)]
        public string CoverFileCategory { get; set; }

        /// <summary>
        /// <para>The ID of the cover file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d79206586bb5dd69fb34c349282718146c55da7</para>
        /// </summary>
        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        /// <summary>
        /// <para>The score of the cover image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.736</para>
        /// </summary>
        [NameInMap("cover_overall_score")]
        [Validation(Required=false)]
        public float? CoverOverallScore { get; set; }

        /// <summary>
        /// <para>The confidence level of the cover image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cover_tag_confidence")]
        [Validation(Required=false)]
        public float? CoverTagConfidence { get; set; }

        /// <summary>
        /// <para>The URL of the cover image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("cover_url")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <para>The name of the tag.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
