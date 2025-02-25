// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetErrorsResponseBody : TeaModel {
        /// <summary>
        /// <para>Args</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetErrorsResponseBodyModel Model { get; set; }
        public class GetErrorsResponseBodyModel : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetErrorsResponseBodyModelItems> Items { get; set; }
            public class GetErrorsResponseBodyModelItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1740488561065</para>
                /// </summary>
                [NameInMap("ClientTime")]
                [Validation(Required=false)]
                public long? ClientTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RANDOM-1729634758587856312DEVICE</para>
                /// </summary>
                [NameInMap("Did")]
                [Validation(Required=false)]
                public string Did { get; set; }

                /// <summary>
                /// <para>Utdid</para>
                /// 
                /// <b>Example:</b>
                /// <para>RANDOM-1729634758587856312DEVICE</para>
                /// </summary>
                [NameInMap("Utdid")]
                [Validation(Required=false)]
                public string Utdid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9634758587856312DEV</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public int? Pages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3AD0FE4-36EF-1641-90B1-77618166F2ff</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
