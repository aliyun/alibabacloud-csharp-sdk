// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAskLumaLogResult : TeaModel {
        /// <summary>
        /// <para>The list of log records returned by the query.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<AskLumaLogEntry> Entries { get; set; }

        /// <summary>
        /// <para>Indicates whether more query results are available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: More results are available.</description></item>
        /// <item><description>false: No more results are available.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of query results. Pass this value as LastKey in subsequent requests to continue the query. This field is not returned when all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ0cyI6MTcxN...</para>
        /// </summary>
        [NameInMap("LastKey")]
        [Validation(Required=false)]
        public string LastKey { get; set; }

    }

}
