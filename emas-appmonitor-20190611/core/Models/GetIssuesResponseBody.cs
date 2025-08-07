// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetIssuesResponseBody : TeaModel {
        /// <summary>
        /// <para>Args</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetIssuesResponseBodyModel Model { get; set; }
        public class GetIssuesResponseBodyModel : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetIssuesResponseBodyModelItems> Items { get; set; }
            public class GetIssuesResponseBodyModelItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AffectedUserCount")]
                [Validation(Required=false)]
                public int? AffectedUserCount { get; set; }

                [NameInMap("AllocSizeMax")]
                [Validation(Required=false)]
                public long? AllocSizeMax { get; set; }

                [NameInMap("AllocSizePct50")]
                [Validation(Required=false)]
                public long? AllocSizePct50 { get; set; }

                [NameInMap("AllocSizePct70")]
                [Validation(Required=false)]
                public long? AllocSizePct70 { get; set; }

                [NameInMap("AllocSizePct90")]
                [Validation(Required=false)]
                public long? AllocSizePct90 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-3481243636390427020</para>
                /// </summary>
                [NameInMap("DigestHash")]
                [Validation(Required=false)]
                public string DigestHash { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DomScore")]
                [Validation(Required=false)]
                public string DomScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorColumn")]
                [Validation(Required=false)]
                public int? ErrorColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public int? ErrorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorDeviceCount")]
                [Validation(Required=false)]
                public int? ErrorDeviceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("ErrorDeviceRate")]
                [Validation(Required=false)]
                public double? ErrorDeviceRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.js</para>
                /// </summary>
                [NameInMap("ErrorFileName")]
                [Validation(Required=false)]
                public string ErrorFileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorLine")]
                [Validation(Required=false)]
                public int? ErrorLine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ErrorName</para>
                /// </summary>
                [NameInMap("ErrorName")]
                [Validation(Required=false)]
                public string ErrorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ErrorRate")]
                [Validation(Required=false)]
                public double? ErrorRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("ErrorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1691745496851</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("FirstVersion")]
                [Validation(Required=false)]
                public string FirstVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ServiceType</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>java.lang.NullPointerException: Attempt to invoke virtual method \&quot;java.lang.Object java.lang.ref.WeakReference.get()\&quot; on a null object reference
                ///     at e.l.a.a.d.h(BasePresenter.java:1)
                ///     at e.l.a.g.c.e.g.s1(GoodsPigLoadPresenter.java:1)
                ///     at e.l.a.h.d.a$a.a(AliOssManager.java:2)</para>
                /// </summary>
                [NameInMap("Stack")]
                [Validation(Required=false)]
                public string Stack { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CREATE_COMPLETE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22111548-55D2-4258-9B18-273E4C134444</para>
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
