// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTaxiInvoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTaxiInvoiceResponseBodyData Data { get; set; }
        public class RecognizeTaxiInvoiceResponseBodyData : TeaModel {
            [NameInMap("Invoices")]
            [Validation(Required=false)]
            public List<RecognizeTaxiInvoiceResponseBodyDataInvoices> Invoices { get; set; }
            public class RecognizeTaxiInvoiceResponseBodyDataInvoices : TeaModel {
                public RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi InvoiceRoi { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi : TeaModel {
                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public float? H { get; set; }

                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public float? W { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }
                public List<RecognizeTaxiInvoiceResponseBodyDataInvoicesItems> Items { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItems : TeaModel {
                    public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoi ItemRoi { get; set; }
                    public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoi : TeaModel {
                        [NameInMap("Angle")]
                        [Validation(Required=false)]
                        public float? Angle { get; set; }

                        [NameInMap("Center")]
                        [Validation(Required=false)]
                        public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiCenter Center { get; set; }
                        public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiCenter : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public float? X { get; set; }
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public float? Y { get; set; }
                        };

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiSize Size { get; set; }
                        public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiSize : TeaModel {
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public float? H { get; set; }
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public float? W { get; set; }
                        };

                    }
                    public string Text { get; set; }
                }
                public int? RotateType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
