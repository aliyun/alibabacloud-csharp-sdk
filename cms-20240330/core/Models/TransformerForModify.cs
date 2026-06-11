// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformerForModify : TeaModel {
        /// <summary>
        /// <para>The transform operations.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<TransformAction> Actions { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The filter criteria.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Specifies whether to exit after a match is processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("quitAfterMatch")]
        [Validation(Required=false)]
        public bool? QuitAfterMatch { get; set; }

        /// <summary>
        /// <para>The sort number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sortId")]
        [Validation(Required=false)]
        public int? SortId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("transformerName")]
        [Validation(Required=false)]
        public string TransformerName { get; set; }

    }

}
