// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListSystemLogsResponseBody : TeaModel {
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        [NameInMap("SystemLogs")]
        [Validation(Required=false)]
        public List<ListSystemLogsResponseBodySystemLogs> SystemLogs { get; set; }
        public class ListSystemLogsResponseBodySystemLogs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>You are using******</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Error。</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

    }

}
