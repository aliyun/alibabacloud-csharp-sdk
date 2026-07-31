// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeMvRecommendSubTasksRequest : TeaModel {
        /// <summary>
        /// <para>A static value. This parameter cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modification is not supported.</para>
        /// </summary>
        [NameInMap("ActionInner")]
        [Validation(Required=false)]
        public string ActionInner { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>A static value. This parameter cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Modification is not supported.</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The sorting criteria.
        /// Valid values for \<c>Type\\</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>Asc</para>
        /// </description></item>
        /// <item><description><para>Desc</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for \<c>Field\\</c>:</para>
        /// <list type="bullet">
        /// <item><description><para>StartTime</para>
        /// </description></item>
        /// <item><description><para>EndTime</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;: \&quot;ASC\&quot;, \&quot;Field\&quot;: \&quot;StartTime\&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The subtask ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SubtaskId")]
        [Validation(Required=false)]
        public long? SubtaskId { get; set; }

        /// <summary>
        /// <para>The name of the materialized view recommendation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_task_1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
