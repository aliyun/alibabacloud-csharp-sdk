// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListTicketsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListTicketsResponseBodyPage Page { get; set; }
        public class ListTicketsResponseBodyPage : TeaModel {
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
            /// <para>5</para>
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
        public List<ListTicketsResponseBodyResult> Result { get; set; }
        public class ListTicketsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public bool? Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AssignedHandler")]
            [Validation(Required=false)]
            public string AssignedHandler { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ChargesRemark")]
            [Validation(Required=false)]
            public string ChargesRemark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CompleteRemark")]
            [Validation(Required=false)]
            public string CompleteRemark { get; set; }

            [NameInMap("Dialogs")]
            [Validation(Required=false)]
            public List<ListTicketsResponseBodyResultDialogs> Dialogs { get; set; }
            public class ListTicketsResponseBodyResultDialogs : TeaModel {
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-09 00:00:00</para>
            /// </summary>
            [NameInMap("GmtCalled")]
            [Validation(Required=false)]
            public string GmtCalled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-09 00:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-09 00:00:00</para>
            /// </summary>
            [NameInMap("GmtDelayed")]
            [Validation(Required=false)]
            public string GmtDelayed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-09 00:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023***93975</para>
            /// </summary>
            [NameInMap("GroupKey")]
            [Validation(Required=false)]
            public string GroupKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAcceptedCharges")]
            [Validation(Required=false)]
            public bool? IsAcceptedCharges { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDelayed")]
            [Validation(Required=false)]
            public bool? IsDelayed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsNeedCallback")]
            [Validation(Required=false)]
            public bool? IsNeedCallback { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsNeedCharges")]
            [Validation(Required=false)]
            public bool? IsNeedCharges { get; set; }

            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Operations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>waiting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
