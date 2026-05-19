// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RunCompletionMessageShrinkRequest : TeaModel {
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public string MessagesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TYXM_PLUS</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
