// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesInput : TeaModel {
        /// <summary>
        /// <para>The comprehensive filter conditions for querying alert rules. Supports combined filtering by multiple dimensions such as name, status, severity level, tags, and notification channels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;:{&quot;eq&quot;:&quot;Alarm&quot;},&quot;severityLevels&quot;:{&quot;contains&quot;:[&quot;CRITICAL&quot;,&quot;ERROR&quot;]}}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public QueryAlertRulesFilter Filter { get; set; }

        /// <summary>
        /// <para>The pagination mode parameter. keyset indicates keyset-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pageNumber&quot;:1,&quot;pageSize&quot;:20}</para>
        /// </summary>
        [NameInMap("pagination")]
        [Validation(Required=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// <para>The observable workspace name. If this parameter is not specified, all alert rules are returned based on the caller identity (callerUserId + callerRegionId). If this parameter is specified, only the rules under the specified workspace are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
