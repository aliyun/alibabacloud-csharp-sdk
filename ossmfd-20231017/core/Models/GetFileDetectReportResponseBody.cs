// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class GetFileDetectReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectReportResponseBodyData Data { get; set; }
        public class GetFileDetectReportResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;sha256&quot;: &quot;&quot;,
            ///         &quot;sha512&quot;: &quot;&quot;,
            ///         &quot;source&quot;: &quot;aegis&quot;,
            ///         &quot;gmt_first_submit&quot;: &quot;&quot;,
            ///         &quot;sha1&quot;: &quot;&quot;,
            ///         &quot;virus_result&quot;: &quot;&quot;,
            ///         &quot;webshell_result&quot;: &quot;&quot;,
            ///         &quot;gmt_update&quot;: &quot;&quot;,
            ///         &quot;sandbox_result&quot;: &quot;2&quot;,
            ///         &quot;fileSize&quot;: &quot;363752&quot;,
            ///         &quot;virus_name&quot;: &quot;&quot;,
            ///     }</para>
            /// </summary>
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public string Basic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4206dbcf1c2bc80ea95ad64043******</para>
            /// </summary>
            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testFile******</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasData")]
            [Validation(Required=false)]
            public bool? HasData { get; set; }

            [NameInMap("Intelligences")]
            [Validation(Required=false)]
            public string Intelligences { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;BehaviorData\&quot;: {}, \&quot;ProcessData\&quot;: {}, \&quot;SandboxData\&quot;: {}, \&quot;AttackData\&quot;: [], \&quot;NetworkData\&quot;: {}, \&quot;SolutionData\&quot;: {}, \&quot;FileData\&quot;: {}}</para>
            /// </summary>
            [NameInMap("Sandbox")]
            [Validation(Required=false)]
            public string Sandbox { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowTab")]
            [Validation(Required=false)]
            public bool? ShowTab { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public long? ThreatLevel { get; set; }

            [NameInMap("ThreatTypes")]
            [Validation(Required=false)]
            public string ThreatTypes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAC546A5-5EDC-5939-86A3-56DFAF******</para>
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
