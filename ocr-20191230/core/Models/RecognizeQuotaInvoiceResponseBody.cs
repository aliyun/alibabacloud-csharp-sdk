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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public RecognizeQuotaInvoiceResponseBodyDataContent Content { get; set; }
            public class RecognizeQuotaInvoiceResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>144031800103</para>
                /// </summary>
                [NameInMap("InvoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("InvoiceDetails")]
                [Validation(Required=false)]
                public string InvoiceDetails { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40637706</para>
                /// </summary>
                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("SumAmount")]
                [Validation(Required=false)]
                public string SumAmount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>624</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>544</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>387</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ValueScore")]
                [Validation(Required=false)]
                public float? ValueScore { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>610</para>
            /// </summary>
            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>855</para>
            /// </summary>
            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>865</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BC4C12D0-7FD3-419A-B997-A91212DF6D82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
