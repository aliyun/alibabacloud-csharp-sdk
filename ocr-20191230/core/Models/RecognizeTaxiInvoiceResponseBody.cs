// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTaxiInvoiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTaxiInvoiceResponseBodyData Data { get; set; }
        public class RecognizeTaxiInvoiceResponseBodyData : TeaModel {
            [NameInMap("Invoices")]
            [Validation(Required=false)]
            public List<RecognizeTaxiInvoiceResponseBodyDataInvoices> Invoices { get; set; }
            public class RecognizeTaxiInvoiceResponseBodyDataInvoices : TeaModel {
                public List<RecognizeTaxiInvoiceResponseBodyDataInvoicesItems> Items { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItems : TeaModel {
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsSize Size { get; set; }
                    public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsSize : TeaModel {
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public float? W { get; set; }
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public float? H { get; set; }
                    };

                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public float? Angle { get; set; }

                    [NameInMap("Center")]
                    [Validation(Required=false)]
                    public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsCenter Center { get; set; }
                    public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsCenter : TeaModel {
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }
                    };

                }
                public int? RotateType { get; set; }
                public RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi InvoiceRoi { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi : TeaModel {
                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public float? W { get; set; }

                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public float? H { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                }
            }
        };

    }

}
