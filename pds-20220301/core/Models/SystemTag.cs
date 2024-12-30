// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SystemTag : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.877</para>
        /// </summary>
        [NameInMap("centric_score")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.98</para>
        /// </summary>
        [NameInMap("confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>篮球</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>运动</para>
        /// </summary>
        [NameInMap("parent_name")]
        [Validation(Required=false)]
        public string ParentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("tag_level")]
        [Validation(Required=false)]
        public int? TagLevel { get; set; }

    }

}
