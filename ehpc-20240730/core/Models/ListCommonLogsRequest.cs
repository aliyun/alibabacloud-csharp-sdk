// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListCommonLogsRequest : TeaModel {
        /// <summary>
        /// <para>The action types.</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public List<string> ActionName { get; set; }

        /// <summary>
        /// <para>The action status. Logs associated with the specific action status are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished: The action is completed.</description></item>
        /// <item><description>Failed: The action failed.</description></item>
        /// <item><description>InProgress: The action is being performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("ActionStatus")]
        [Validation(Required=false)]
        public string ActionStatus { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The start time of the time range. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703821542</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>Specifies whether to display results in reverse order.</para>
        /// <para>Default value: true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsReverse")]
        [Validation(Required=false)]
        public bool? IsReverse { get; set; }

        /// <summary>
        /// <para>The request ID of the action. Logs associated with the specific request ID are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// <para>The log type. Logs of the specific type are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The account ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137***</para>
        /// </summary>
        [NameInMap("OperatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the resource involved in the action. Logs associated with the specific resource are returned. This parameter is not recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-abc***</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The end time of the time range. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703821666</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
