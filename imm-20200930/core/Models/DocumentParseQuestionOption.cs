// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentParseQuestionOption : TeaModel {
        /// <summary>
        /// <para>Number of questions (range: 0 to 10)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Whether to extract</para>
        /// </summary>
        [NameInMap("Extract")]
        [Validation(Required=false)]
        public bool? Extract { get; set; }

    }

}
