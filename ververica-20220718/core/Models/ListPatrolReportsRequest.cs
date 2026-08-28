// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListPatrolReportsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. Unit: milliseconds (UNIX timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718086400000</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Filters reports by inspection scope type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL</description></item>
        /// <item><description>TAGS</description></item>
        /// <item><description>DEPLOYMENTS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The start time of the query. Unit: milliseconds (UNIX timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718000000000</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>Filters reports by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PENDING</description></item>
        /// <item><description>IN_PROGRESS</description></item>
        /// <item><description>COMPLETED</description></item>
        /// <item><description>FAILED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters reports by trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CRON</description></item>
        /// <item><description>MANUAL</description></item>
        /// <item><description>INNER_API</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CRON</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
