// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeQuotaInvoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeQuotaInvoiceResponseBodyData Data { get; set; }
        public class RecognizeQuotaInvoiceResponseBodyData : TeaModel {
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public RecognizeQuotaInvoiceResponseBodyDataContent Content { get; set; }
            public class RecognizeQuotaInvoiceResponseBodyDataContent : TeaModel {
                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

                [NameInMap("InvoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("InvoiceDetails")]
                [Validation(Required=false)]
                public string InvoiceDetails { get; set; }

                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("SumAmount")]
                [Validation(Required=false)]
                public string SumAmount { get; set; }

            }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            [NameInMap("KeyValueInfos")]
            [Validation(Required=false)]
            public List<RecognizeQuotaInvoiceResponseBodyDataKeyValueInfos> KeyValueInfos { get; set; }
            public class RecognizeQuotaInvoiceResponseBodyDataKeyValueInfos : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ValuePositions")]
                [Validation(Required=false)]
                public List<RecognizeQuotaInvoiceResponseBodyDataKeyValueInfosValuePositions> ValuePositions { get; set; }
                public class RecognizeQuotaInvoiceResponseBodyDataKeyValueInfosValuePositions : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                [NameInMap("ValueScore")]
                [Validation(Required=false)]
                public float? ValueScore { get; set; }

            }

            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }

            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
