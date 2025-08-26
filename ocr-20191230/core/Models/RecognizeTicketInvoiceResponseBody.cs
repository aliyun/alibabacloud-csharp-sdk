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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>594</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1417</para>
            /// </summary>
            [NameInMap("OrgHeight")]
            [Validation(Required=false)]
            public long? OrgHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1417</para>
            /// </summary>
            [NameInMap("OrgWidth")]
            [Validation(Required=false)]
            public long? OrgWidth { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RecognizeTicketInvoiceResponseBodyDataResults> Results { get; set; }
            public class RecognizeTicketInvoiceResponseBodyDataResults : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public RecognizeTicketInvoiceResponseBodyDataResultsContent Content { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>81931914902643039780</para>
                    /// </summary>
                    [NameInMap("AntiFakeCode")]
                    [Validation(Required=false)]
                    public string AntiFakeCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>044031860107</para>
                    /// </summary>
                    [NameInMap("InvoiceCode")]
                    [Validation(Required=false)]
                    public string InvoiceCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2018-09-20</para>
                    /// </summary>
                    [NameInMap("InvoiceDate")]
                    [Validation(Required=false)]
                    public string InvoiceDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>09267581</para>
                    /// </summary>
                    [NameInMap("InvoiceNumber")]
                    [Validation(Required=false)]
                    public string InvoiceNumber { get; set; }

                    [NameInMap("PayeeName")]
                    [Validation(Required=false)]
                    public string PayeeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>914403002794492693</para>
                    /// </summary>
                    [NameInMap("PayeeRegisterNo")]
                    [Validation(Required=false)]
                    public string PayeeRegisterNo { get; set; }

                    [NameInMap("PayerName")]
                    [Validation(Required=false)]
                    public string PayerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>91440300MA5EXWHW6F</para>
                    /// </summary>
                    [NameInMap("PayerRegisterNo")]
                    [Validation(Required=false)]
                    public string PayerRegisterNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>￥220.00</para>
                    /// </summary>
                    [NameInMap("SumAmount")]
                    [Validation(Required=false)]
                    public string SumAmount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                [NameInMap("KeyValueInfos")]
                [Validation(Required=false)]
                public List<RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfos> KeyValueInfos { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfos : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>044031860107</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValuePositions")]
                    [Validation(Required=false)]
                    public List<RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfosValuePositions> ValuePositions { get; set; }
                    public class RecognizeTicketInvoiceResponseBodyDataResultsKeyValueInfosValuePositions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>586</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>16</para>
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

                [NameInMap("SliceRectangle")]
                [Validation(Required=false)]
                public List<RecognizeTicketInvoiceResponseBodyDataResultsSliceRectangle> SliceRectangle { get; set; }
                public class RecognizeTicketInvoiceResponseBodyDataResultsSliceRectangle : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>586</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>594</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>063C0178-7EA3-4754-96FB-C0C9AE6B9AAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
