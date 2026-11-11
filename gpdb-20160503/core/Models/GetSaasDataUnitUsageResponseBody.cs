// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSaasDataUnitUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>按DataUnit降序，未知金额排末尾，同值按场景码、项目ID和名称升序。按场景和项目ID分组；无ID但有名称按名称分组；两者均缺失的记录为未关联项目。完整结果各项之和等于汇总；缺失或空白的日志场景归other（其他）；有值但未配置映射的场景保留原值作为编码和展示名，正常计入总量；无记录的other不创建空行。</para>
        /// </summary>
        [NameInMap("Distribution")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyDistribution> Distribution { get; set; }
        public class GetSaasDataUnitUsageResponseBodyDistribution : TeaModel {
            /// <summary>
            /// <para>精确非负十进制字符串，不使用浮点或指数格式；金额不完整时为null。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

            /// <summary>
            /// <para>调用时的项目归因；缺失时为null，不影响总量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>同一场景和项目ID取查询范围内最新非空名称快照，同秒取字典序最大值；缺失为null。</para>
            /// 
            /// <b>Example:</b>
            /// <para>场景重制</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>drama_game_oneshot</para>
            /// </summary>
            [NameInMap("UsageScene")]
            [Validation(Required=false)]
            public string UsageScene { get; set; }

            /// <summary>
            /// <para>由Meta原值到中文名的字典补充，不是SLS字段。UsageScene始终保留日志原值；无中文名则名称也用原值；空白归其他。同中文名不同编码不合并。</para>
            /// 
            /// <b>Example:</b>
            /// <para>游戏生成</para>
            /// </summary>
            [NameInMap("UsageSceneName")]
            [Validation(Required=false)]
            public string UsageSceneName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mock_req_success</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agdb-example</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public GetSaasDataUnitUsageResponseBodySummary Summary { get; set; }
        public class GetSaasDataUnitUsageResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>精确非负十进制字符串，不使用浮点或指数格式；金额不完整时为null。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

        }

        /// <summary>
        /// <para>按UTC桶起点升序。完整查询补齐零桶；未知金额为null，不以零替代。</para>
        /// </summary>
        [NameInMap("TimeSeries")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyTimeSeries> TimeSeries { get; set; }
        public class GetSaasDataUnitUsageResponseBodyTimeSeries : TeaModel {
            /// <summary>
            /// <para>精确非负十进制字符串，不使用浮点或指数格式；金额不完整时为null。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

            [NameInMap("Scenes")]
            [Validation(Required=false)]
            public List<GetSaasDataUnitUsageResponseBodyTimeSeriesScenes> Scenes { get; set; }
            public class GetSaasDataUnitUsageResponseBodyTimeSeriesScenes : TeaModel {
                /// <summary>
                /// <para>精确非负十进制字符串，不使用浮点或指数格式；金额不完整时为null。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.82</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("DataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>调用时的项目归因；缺失时为null，不影响总量。</para>
                /// 
                /// <b>Example:</b>
                /// <para>project-1</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>同一场景和项目ID取查询范围内最新非空名称快照，同秒取字典序最大值；缺失为null。</para>
                /// 
                /// <b>Example:</b>
                /// <para>场景重制</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>game_translation</para>
                /// </summary>
                [NameInMap("UsageScene")]
                [Validation(Required=false)]
                public string UsageScene { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-10-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyWarnings> Warnings { get; set; }
        public class GetSaasDataUnitUsageResponseBodyWarnings : TeaModel {
            /// <summary>
            /// <para>包括DATA_INCOMPLETE和DATA_UNIT_PENDING。</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_INCOMPLETE</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部分用量尚未就绪</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
