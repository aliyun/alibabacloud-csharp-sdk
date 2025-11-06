// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListAnalysisCoreIndexResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListAnalysisCoreIndexResponseBodyResultContent ResultContent { get; set; }
        public class ListAnalysisCoreIndexResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListAnalysisCoreIndexResponseBodyResultContentData Data { get; set; }
            public class ListAnalysisCoreIndexResponseBodyResultContentData : TeaModel {
                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ArrivalNum")]
                [Validation(Required=false)]
                public string ArrivalNum { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ArrivalRate")]
                [Validation(Required=false)]
                public string ArrivalRate { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreNum")]
                [Validation(Required=false)]
                public string IgnoreNum { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreRate")]
                [Validation(Required=false)]
                public string IgnoreRate { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OpenNum")]
                [Validation(Required=false)]
                public string OpenNum { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OpenRate")]
                [Validation(Required=false)]
                public string OpenRate { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PushNum")]
                [Validation(Required=false)]
                public string PushNum { get; set; }

                /// <summary>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PushTotalNum")]
                [Validation(Required=false)]
                public string PushTotalNum { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
