// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTrainTicketResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTrainTicketResponseBodyData Data { get; set; }
        public class RecognizeTrainTicketResponseBodyData : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }
            [NameInMap("DepartureStation")]
            [Validation(Required=false)]
            public string DepartureStation { get; set; }
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }
            [NameInMap("Seat")]
            [Validation(Required=false)]
            public string Seat { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
