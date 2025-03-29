// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GenericSearchRequest : TeaModel {
        [NameInMap("enableRerank")]
        [Validation(Required=false)]
        public bool? EnableRerank { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("returnMainText")]
        [Validation(Required=false)]
        public bool? ReturnMainText { get; set; }

        [NameInMap("returnMarkdownText")]
        [Validation(Required=false)]
        public bool? ReturnMarkdownText { get; set; }

        [NameInMap("returnSummary")]
        [Validation(Required=false)]
        public bool? ReturnSummary { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
