// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCustomQAV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string AnswersShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520a0c0***5eb</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public string KeyWordsShrink { get; set; }

        [NameInMap("MajorQuestion")]
        [Validation(Required=false)]
        public string MajorQuestion { get; set; }

        [NameInMap("SupplementaryQuestions")]
        [Validation(Required=false)]
        public string SupplementaryQuestionsShrink { get; set; }

    }

}
