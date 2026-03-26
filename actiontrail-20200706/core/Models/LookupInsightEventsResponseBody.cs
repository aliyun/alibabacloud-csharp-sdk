// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupInsightEventsResponseBody : TeaModel {
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Events { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VjE6bHJlTGoxdm1M****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>851038F3-33AB-4C49-97D7-6AB37D35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
