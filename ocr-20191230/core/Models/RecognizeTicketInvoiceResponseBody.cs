// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeTicketInvoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeTicketInvoiceResponseBodyData Data { get; set; }
        public class RecognizeTicketInvoiceResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }
            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RecognizeTicketInvoiceResponseBodyDataResults> Results { get; set; }
            public class RecognizeTicketInvoiceResponseBodyDataResults : TeaModel {
                public RecognizeTicketInvoiceResponseBodyDataResultsContent Content { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsContent : TeaModel {
                    [NameInMap("AntiFakeCode")]
                    [Validation(Required=false)]
                    public string AntiFakeCode { get; set; }

                    [NameInMap("InvoiceCode")]
                    [Validation(Required=false)]
                    public string InvoiceCode { get; set; }

                    [NameInMap("InvoiceDate")]
                    [Validation(Required=false)]
                    public string InvoiceDate { get; set; }

                    [NameInMap("InvoiceNumber")]
                    [Validation(Required=false)]
                    public string InvoiceNumber { get; set; }

                    [NameInMap("PayeeName")]
                    [Validation(Required=false)]
                    public string PayeeName { get; set; }

                    [NameInMap("PayeeRegisterNo")]
                    [Validation(Required=false)]
                    public string PayeeRegisterNo { get; set; }

                    [NameInMap("PayerName")]
                    [Validation(Required=false)]
                    public string PayerName { get; set; }

                    [NameInMap("PayerRegisterNo")]
                    [Validation(Required=false)]
                    public string PayerRegisterNo { get; set; }

                    [NameInMap("SumAmount")]
                    [Validation(Required=false)]
                    public string SumAmount { get; set; }

                }
                public long? Index { get; set; }
                public List<RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfos> KeyValueInfos { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfos : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                    public List<RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfosValuePositions> ValuePositions { get; set; }
                    public class RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfosValuePositions : TeaModel {
                        public long? X { get; set; }
                        public long? Y { get; set; }
                    }
                    public float? ValueScore { get; set; }
                }
                public List<RecognizeTicketInvoiceResponseBodyDataResultsSliceRectangle> SliceRectangle { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsSliceRectangle : TeaModel {
                    public long? X { get; set; }
                    public long? Y { get; set; }
                }
                public string Type { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
