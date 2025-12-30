// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBIPatternIndexQueryTablesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;tableName&quot;: &quot;pattern_index_1&quot;，&quot;patternTableName&quot;: &quot;polar4ai_nl2sql_pattern_1&quot;, &quot;tableStatus&quot;: 0},
        /// {&quot;tableName&quot;: &quot;pattern_index_2&quot;，&quot;patternTableName&quot;: &quot;polar4ai_nl2sql_pattern_2&quot;, &quot;tableStatus&quot;: 1},
        /// {&quot;tableName&quot;: &quot;pattern_index_3&quot;，&quot;patternTableName&quot;: &quot;polar4ai_nl2sql_pattern_3, &quot;tableStatus&quot;: 2}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误码</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误信息</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>983863E2-****-1D15-A4AE-3468CD75383D</para>
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
