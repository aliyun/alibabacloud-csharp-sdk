// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetIssueResponseBody : TeaModel {
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
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public GetIssueResponseBodyModel Model { get; set; }
        public class GetIssueResponseBodyModel : TeaModel {
            [NameInMap("AffectedVersions")]
            [Validation(Required=false)]
            public List<string> AffectedVersions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException: Attempt to invoke virtual method \&quot;java.lang.Object java.lang.ref.WeakReference.get()\&quot; on a null object reference
            ///     at e.l.a.a.d.h(BasePresenter.java:1)
            ///     at e.l.a.g.c.e.g.s1(GoodsPigLoadPresenter.java:1)
            ///     at e.l.a.h.d.a$a.a(AliOssManager.java:2)</para>
            /// </summary>
            [NameInMap("CruxStack")]
            [Validation(Required=false)]
            public string CruxStack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-6428474329608402395</para>
            /// </summary>
            [NameInMap("DigestHash")]
            [Validation(Required=false)]
            public string DigestHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ErrorCountGrowthRate")]
            [Validation(Required=false)]
            public double? ErrorCountGrowthRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ErrorDeviceCount")]
            [Validation(Required=false)]
            public int? ErrorDeviceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ErrorDeviceCountGrowthRate")]
            [Validation(Required=false)]
            public double? ErrorDeviceCountGrowthRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ErrorDeviceRate")]
            [Validation(Required=false)]
            public double? ErrorDeviceRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ErrorDeviceRateGrowthRate")]
            [Validation(Required=false)]
            public double? ErrorDeviceRateGrowthRate { get; set; }

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
            public string ErrorLine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Error</para>
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
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ErrorRateGrowthRate")]
            [Validation(Required=false)]
            public double? ErrorRateGrowthRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ErrorType</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("FirstVersion")]
            [Validation(Required=false)]
            public string FirstVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1673423227000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1740489688615</para>
            /// </summary>
            [NameInMap("GmtLatest")]
            [Validation(Required=false)]
            public long? GmtLatest { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeyLine")]
            [Validation(Required=false)]
            public int? KeyLine { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java.lang.NullPointerException</para>
            /// </summary>
            [NameInMap("Stack")]
            [Validation(Required=false)]
            public string Stack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trustee instance</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SymbolicStatus")]
            [Validation(Required=false)]
            public bool? SymbolicStatus { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A8313212-EB4E-4E15-A7F9-D9C8F3FE8E94</para>
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
