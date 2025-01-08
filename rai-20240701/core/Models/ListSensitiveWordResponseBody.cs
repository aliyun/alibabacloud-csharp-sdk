// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSensitiveWordResponseBodyData Data { get; set; }
        public class ListSensitiveWordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

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

            [NameInMap("SensitiveWordList")]
            [Validation(Required=false)]
            public List<ListSensitiveWordResponseBodyDataSensitiveWordList> SensitiveWordList { get; set; }
            public class ListSensitiveWordResponseBodyDataSensitiveWordList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>387907</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
