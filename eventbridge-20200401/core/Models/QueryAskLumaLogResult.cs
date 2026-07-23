// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAskLumaLogResult : TeaModel {
        /// <summary>
        /// <para>The log entries returned by the query.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<AskLumaLogEntry> Entries { get; set; }

        /// <summary>
        /// <para>Specifies whether more results are available. The value is <c>true</c> if more results can be retrieved, and <c>false</c> otherwise.</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The token to use for retrieving the next page of results. If present, pass this value as the <c>LastKey</c> parameter in a subsequent request to fetch more data. This field is omitted when all results have been retrieved.</para>
        /// </summary>
        [NameInMap("LastKey")]
        [Validation(Required=false)]
        public string LastKey { get; set; }

    }

}
