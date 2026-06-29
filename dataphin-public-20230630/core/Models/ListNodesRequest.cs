// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment </description></item>
        /// <item><description>PROD (default): production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListNodesRequestListQuery ListQuery { get; set; }
        public class ListNodesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to perform a dry run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The node business type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT: script</description></item>
            /// <item><description>LOGICAL_TABLE: logical table.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("NodeBizType")]
            [Validation(Required=false)]
            public string NodeBizType { get; set; }

            /// <summary>
            /// <para>The sub-business types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeSubBizTypeList")]
            [Validation(Required=false)]
            public List<string> NodeSubBizTypeList { get; set; }

            /// <summary>
            /// <para>The user IDs of the owners.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The node priorities. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HIGHEST</description></item>
            /// <item><description>HIGH</description></item>
            /// <item><description>MIDDLE</description></item>
            /// <item><description>LOW</description></item>
            /// <item><description>LOWEST.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("PriorityList")]
            [Validation(Required=false)]
            public List<string> PriorityList { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12111</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Specifies whether scheduling is paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SchedulePaused")]
            [Validation(Required=false)]
            public bool? SchedulePaused { get; set; }

            /// <summary>
            /// <para>The scheduling periods. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>YEARLY</description></item>
            /// <item><description>MONTHLY</description></item>
            /// <item><description>WEEKLY</description></item>
            /// <item><description>DAILY</description></item>
            /// <item><description>HOURLY</description></item>
            /// <item><description>MINUTELY.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SchedulePeriodList")]
            [Validation(Required=false)]
            public List<string> SchedulePeriodList { get; set; }

            /// <summary>
            /// <para>The node scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: periodic scheduling</description></item>
            /// <item><description>SUPPLEMENT: data backfill</description></item>
            /// <item><description>MANUAL: manual scheduling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The search keyword. Fuzzy search by node name and exact search by node ID are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("SearchText")]
            [Validation(Required=false)]
            public string SearchText { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
