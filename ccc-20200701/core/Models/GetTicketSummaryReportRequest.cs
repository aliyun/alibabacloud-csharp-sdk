// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketSummaryReportRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>assignee@ccc-test</para>
        /// </summary>
        [NameInMap("Assignee")]
        [Validation(Required=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Agent</para>
        /// </summary>
        [NameInMap("AssigneeType")]
        [Validation(Required=false)]
        public string AssigneeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43c2671b-<em><b>-</b></em>-86d0-6bd187905cc8</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>creator@ccc-test</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1719590399999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>participant@ccc-test</para>
        /// </summary>
        [NameInMap("Participant")]
        [Validation(Required=false)]
        public string Participant { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1716998400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
