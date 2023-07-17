// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateCustomQARequest : TeaModel {
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public List<string> Answers { get; set; }

        [NameInMap("CustomQAId")]
        [Validation(Required=false)]
        public string CustomQAId { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public List<string> KeyWords { get; set; }

        [NameInMap("MajorQuestion")]
        [Validation(Required=false)]
        public string MajorQuestion { get; set; }

        [NameInMap("SupplementaryQuestions")]
        [Validation(Required=false)]
        public List<string> SupplementaryQuestions { get; set; }

    }

}
