// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListIndexVersionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListIndexVersionsResponseBodyResult> Result { get; set; }
        public class ListIndexVersionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-08T02:00:00Z</para>
            /// </summary>
            [NameInMap("builtTime")]
            [Validation(Required=false)]
            public string BuiltTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("costSeconds")]
            [Validation(Required=false)]
            public int? CostSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("flowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("rollbackEnabled")]
            [Validation(Required=false)]
            public bool? RollbackEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300922211</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-08T02:00:00Z</para>
            /// </summary>
            [NameInMap("switchedTime")]
            [Validation(Required=false)]
            public string SwitchedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020112301</para>
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
