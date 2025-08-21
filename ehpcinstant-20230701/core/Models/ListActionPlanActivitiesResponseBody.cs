// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListActionPlanActivitiesResponseBody : TeaModel {
        [NameInMap("ActionPlanActivities")]
        [Validation(Required=false)]
        public List<ListActionPlanActivitiesResponseBodyActionPlanActivities> ActionPlanActivities { get; set; }
        public class ListActionPlanActivitiesResponseBodyActionPlanActivities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>et-4119e3f60eb34fc4</para>
            /// </summary>
            [NameInMap("ActionPlanActivityId")]
            [Validation(Required=false)]
            public string ActionPlanActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CreatedCapacity")]
            [Validation(Required=false)]
            public float? CreatedCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DestroyCapacity")]
            [Validation(Required=false)]
            public float? DestroyCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-10 18:28:05</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListActionPlanActivitiesResponseBodyActionPlanActivitiesJobs> Jobs { get; set; }
            public class ListActionPlanActivitiesResponseBodyActionPlanActivitiesJobs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>job-hz12dqq8y3ormo1hz49h</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("JobOperationType")]
                [Validation(Required=false)]
                public string JobOperationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-10 18:28:05</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InProcess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86scXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
