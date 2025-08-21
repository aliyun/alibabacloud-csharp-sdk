// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScgFilter")]
        [Validation(Required=false)]
        public string ScgFilterShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MC201132</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

    }

}
