// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListInstancesRequestListQuery ListQuery { get; set; }
        public class ListInstancesRequestListQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-31</para>
            /// </summary>
            [NameInMap("MaxBizDate")]
            [Validation(Required=false)]
            public string MaxBizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-31</para>
            /// </summary>
            [NameInMap("MaxRunDate")]
            [Validation(Required=false)]
            public string MaxRunDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-30</para>
            /// </summary>
            [NameInMap("MinBizDate")]
            [Validation(Required=false)]
            public string MinBizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-30</para>
            /// </summary>
            [NameInMap("MinRunDate")]
            [Validation(Required=false)]
            public string MinRunDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n_23131</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PriorityList")]
            [Validation(Required=false)]
            public List<string> PriorityList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131311111321</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("RunStatusList")]
            [Validation(Required=false)]
            public List<string> RunStatusList { get; set; }

            [NameInMap("SchedulePaused")]
            [Validation(Required=false)]
            public bool? SchedulePaused { get; set; }

            [NameInMap("SchedulePeriodList")]
            [Validation(Required=false)]
            public List<string> SchedulePeriodList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("SearchText")]
            [Validation(Required=false)]
            public string SearchText { get; set; }

            [NameInMap("SubBizTypeList")]
            [Validation(Required=false)]
            public List<string> SubBizTypeList { get; set; }

        }

        /// <summary>
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
