// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardStatisticsRequest : TeaModel {
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

        /// <summary>
        /// <para>The statistical query instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StatisticsQuery")]
        [Validation(Required=false)]
        public GetStandardStatisticsRequestStatisticsQuery StatisticsQuery { get; set; }
        public class GetStandardStatisticsRequestStatisticsQuery : TeaModel {
            /// <summary>
            /// <para>The creation time period.</para>
            /// </summary>
            [NameInMap("CreateTimePeriod")]
            [Validation(Required=false)]
            public GetStandardStatisticsRequestStatisticsQueryCreateTimePeriod CreateTimePeriod { get; set; }
            public class GetStandardStatisticsRequestStatisticsQueryCreateTimePeriod : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Specifies whether to include the end time. Default value: false.</para>
                /// </summary>
                [NameInMap("IncludeEndTime")]
                [Validation(Required=false)]
                public bool? IncludeEndTime { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The folder to which the standards belong. The search includes all subfolders under this folder.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dir1</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The stages to which the standards belong.</para>
            /// </summary>
            [NameInMap("StandardStageList")]
            [Validation(Required=false)]
            public List<string> StandardStageList { get; set; }

        }

    }

}
