// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCloudMetricProfilingsResponseBody : TeaModel {
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The profiling information of the cluster.</para>
        /// </summary>
        [NameInMap("Profilings")]
        [Validation(Required=false)]
        public ListCloudMetricProfilingsResponseBodyProfilings Profilings { get; set; }
        public class ListCloudMetricProfilingsResponseBodyProfilings : TeaModel {
            [NameInMap("ProfilingInfo")]
            [Validation(Required=false)]
            public List<ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo> ProfilingInfo { get; set; }
            public class ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo : TeaModel {
                /// <summary>
                /// <para>The duration of the profiling process. Unit: seconds.</para>
                /// <para>Valid values: 10 to 300.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The frequency of the profiling process. Unit: Hz.</para>
                /// <para>Valid values: 1 to 2000</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Freq")]
                [Validation(Required=false)]
                public int? Freq { get; set; }

                /// <summary>
                /// <para>The name of the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute5</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1j76z8dlukzqgl0****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The progress ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21687</para>
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public int? Pid { get; set; }

                /// <summary>
                /// <para>The ID of the profiling process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-hz-i-bplukzqgl****_21687_2019-09-09-02-37-40</para>
                /// </summary>
                [NameInMap("ProfilingId")]
                [Validation(Required=false)]
                public string ProfilingId { get; set; }

                /// <summary>
                /// <para>The time when the profiling was triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-09 02:37:40</para>
                /// </summary>
                [NameInMap("TriggerTime")]
                [Validation(Required=false)]
                public string TriggerTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A05F620-ED46-4A57-95F1-C67D6D3C5DD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
