// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBISchemaIndexQueryTablesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;tableName&quot;: &quot;schema_index_1&quot;，&quot;tablesIncluded&quot;: &quot;&quot;, &quot;columnsExcluded&quot;: &quot;&quot;, &quot;toSample&quot;: 0, &quot;tableStatus&quot;: 0},
        /// {&quot;tableName&quot;: &quot;schema_index_2&quot;，&quot;tablesIncluded&quot;: &quot;&quot;, &quot;columnsExcluded&quot;: &quot;&quot;, &quot;toSample&quot;: 0, &quot;tableStatus&quot;: 1},
        /// {&quot;tableName&quot;: &quot;schema_index_3&quot;，&quot;tablesIncluded&quot;: &quot;&quot;, &quot;columnsExcluded&quot;: &quot;&quot;, &quot;toSample&quot;: 0, &quot;tableStatus&quot;: 2}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC388CBF-F12C-57E8-832F-61A18131B106</para>
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
