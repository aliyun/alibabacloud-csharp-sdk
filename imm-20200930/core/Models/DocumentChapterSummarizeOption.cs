// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentChapterSummarizeOption : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return per request. If you do not specify this parameter, the default value is used.</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token. It specifies the starting point for the query. To retrieve the next page of results, set this parameter to the marker value from the previous response.</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public int? Marker { get; set; }

        /// <summary>
        /// <para>The summarization model version. If you do not specify this parameter, the default model version is used.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
