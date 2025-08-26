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
                [NameInMap("InvoiceRoi")]
                [Validation(Required=false)]
                public RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi InvoiceRoi { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesInvoiceRoi : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3625</para>
                    /// </summary>
                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public float? H { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1773</para>
                    /// </summary>
                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public float? W { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>513</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>302</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<RecognizeTaxiInvoiceResponseBodyDataInvoicesItems> Items { get; set; }
                public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItems : TeaModel {
                    [NameInMap("ItemRoi")]
                    [Validation(Required=false)]
                    public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoi ItemRoi { get; set; }
                    public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoi : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-90</para>
                        /// </summary>
                        [NameInMap("Angle")]
                        [Validation(Required=false)]
                        public float? Angle { get; set; }

                        [NameInMap("Center")]
                        [Validation(Required=false)]
                        public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiCenter Center { get; set; }
                        public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiCenter : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1593</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public float? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1360</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public float? Y { get; set; }

                        }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiSize Size { get; set; }
                        public class RecognizeTaxiInvoiceResponseBodyDataInvoicesItemsItemRoiSize : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>81.999984741210938</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public float? H { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>887.9998779296875</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public float? W { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>86655664</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RotateType")]
                [Validation(Required=false)]
                public int? RotateType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B2BBBD26-1D3E-4CFA-A80B-6A9266B8D125</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
