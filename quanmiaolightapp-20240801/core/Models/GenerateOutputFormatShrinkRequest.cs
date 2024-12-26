// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GenerateOutputFormatShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>clueMining</para>
        /// </summary>
        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>待分析文本</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>额外信息</para>
        /// </summary>
        [NameInMap("extraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>给你一条待分析文本数据，请你按照标签体系来对数据进行打标。</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

    }

}
