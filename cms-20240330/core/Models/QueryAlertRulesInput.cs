// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesInput : TeaModel {
        /// <summary>
        /// <para>The filter criteria. Only alert rules that match these criteria are returned.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public QueryAlertRulesFilter Filter { get; set; }

        /// <summary>
        /// <para>The pagination settings for the query. If omitted, the system returns the first page of results with the default page size.</para>
        /// </summary>
        [NameInMap("pagination")]
        [Validation(Required=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the alert rules.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
