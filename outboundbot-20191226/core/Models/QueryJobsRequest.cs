// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsRequest : TeaModel {
        /// <summary>
        /// <para>The contact name for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The end time for filtering. Default value: 0, which indicates the current time. Specify a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579077794665</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>994b8baf-7ef8-480c-b141-b7b6db77c4df</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The contact phone number for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135****8888</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The scenario ID. <b>[Deprecated]</b> Legacy parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0f35dd1-0337-402e-9c4f-3a6c2426950a</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>The start time for filtering. Default value: 0, which indicates 00:00 today. Specify a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579068424883</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The time basis for filtering. This parameter specifies the filtering criterion rather than a specific date or time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>start: Filters by start time.</description></item>
        /// <item><description>end: Filters by end time.</description></item>
        /// <item><description>job_create: Filters by job creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("TimeAlignment")]
        [Validation(Required=false)]
        public string TimeAlignment { get; set; }

    }

}
