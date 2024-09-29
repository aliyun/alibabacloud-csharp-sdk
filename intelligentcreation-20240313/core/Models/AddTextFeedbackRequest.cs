// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class AddTextFeedbackRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8478</para>
        /// </summary>
        [NameInMap("textId")]
        [Validation(Required=false)]
        public long? TextId { get; set; }

    }

}
