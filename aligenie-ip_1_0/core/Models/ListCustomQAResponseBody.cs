// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListCustomQAResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListCustomQAResponseBodyPage Page { get; set; }
        public class ListCustomQAResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7***726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCustomQAResponseBodyResult> Result { get; set; }
        public class ListCustomQAResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>22;11</para>
            /// </summary>
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-10 10:01:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("CustomQAId")]
            [Validation(Required=false)]
            public string CustomQAId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7***83</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22;11</para>
            /// </summary>
            [NameInMap("KeyWords")]
            [Validation(Required=false)]
            public string KeyWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("MajorQuestion")]
            [Validation(Required=false)]
            public string MajorQuestion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22;11</para>
            /// </summary>
            [NameInMap("SupplementaryQuestion")]
            [Validation(Required=false)]
            public string SupplementaryQuestion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-10 10:01:59</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
