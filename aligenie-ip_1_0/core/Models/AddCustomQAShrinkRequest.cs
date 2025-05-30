// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCustomQAShrinkRequest : TeaModel {
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string AnswersShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7a3***013</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public string KeyWordsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("MajorQuestion")]
        [Validation(Required=false)]
        public string MajorQuestion { get; set; }

        [NameInMap("SupplementaryQuestions")]
        [Validation(Required=false)]
        public string SupplementaryQuestionsShrink { get; set; }

    }

}
