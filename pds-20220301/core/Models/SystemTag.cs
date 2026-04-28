// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SystemTag : TeaModel {
        /// <summary>
        /// <para>The center value of the tag, which specifies whether the tag is the subject in the image. Valid values: 0 to 1. A value of 0 specifies the lowest proportion. A value of 1 specifies the highest proportion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.877</para>
        /// </summary>
        [NameInMap("centric_score")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        /// <summary>
        /// <para>The confidence level of the tag. Valid values: 0 to 1. A value of 0 specifies the lowest confidence level. A value of 1 specifies the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.98</para>
        /// </summary>
        [NameInMap("confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// <para>The name of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basketball</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the parent tag of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sport</para>
        /// </summary>
        [NameInMap("parent_name")]
        [Validation(Required=false)]
        public string ParentName { get; set; }

        /// <summary>
        /// <para>The level of the tag. The value must be greater than or equal to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("tag_level")]
        [Validation(Required=false)]
        public int? TagLevel { get; set; }

    }

}
