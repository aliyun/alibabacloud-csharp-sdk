// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketSummaryReportRequest : TeaModel {
        /// <summary>
        /// <para>Assignee ID. This can be an agent ID or a skill group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assignee@ccc-test</para>
        /// </summary>
        [NameInMap("Assignee")]
        [Validation(Required=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// <para>Assignee type.</para>
        /// <list type="bullet">
        /// <item><description><para>Agent</para>
        /// </description></item>
        /// <item><description><para>SkillGroup</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Agent</para>
        /// </summary>
        [NameInMap("AssigneeType")]
        [Validation(Required=false)]
        public string AssigneeType { get; set; }

        /// <summary>
        /// <para>Ticket category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43c2671b-<em><b>-</b></em>-86d0-6bd187905cc8</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>creator@ccc-test</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>End time. Filter tickets by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719590399999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Participant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>participant@ccc-test</para>
        /// </summary>
        [NameInMap("Participant")]
        [Validation(Required=false)]
        public string Participant { get; set; }

        /// <summary>
        /// <para>Start time. Filter tickets by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716998400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Ticket state.</para>
        /// <list type="bullet">
        /// <item><description><para>Processing</para>
        /// </description></item>
        /// <item><description><para>Withdrawal</para>
        /// </description></item>
        /// <item><description><para>Rejected</para>
        /// </description></item>
        /// <item><description><para>Closed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
