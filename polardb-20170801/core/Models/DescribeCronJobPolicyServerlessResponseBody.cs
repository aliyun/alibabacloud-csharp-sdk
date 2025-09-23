// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCronJobPolicyServerlessResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCronJobPolicyServerlessResponseBodyItems> Items { get; set; }
        public class DescribeCronJobPolicyServerlessResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ModifyDBClusterServerlessConf</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowShutDown")]
            [Validation(Required=false)]
            public string AllowShutDown { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 8 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-04T02:25:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12eee3eb-60bd-40ac-a403-218e02eb99c7</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>254752088000354</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScaleApRoNumMax")]
            [Validation(Required=false)]
            public string ScaleApRoNumMax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleApRoNumMin")]
            [Validation(Required=false)]
            public string ScaleApRoNumMin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScaleRoNumMax")]
            [Validation(Required=false)]
            public string ScaleRoNumMax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScaleRoNumMin")]
            [Validation(Required=false)]
            public string ScaleRoNumMin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("SecondsUntilAutoPause")]
            [Validation(Required=false)]
            public string SecondsUntilAutoPause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
            [Validation(Required=false)]
            public string ServerlessRuleCpuEnlargeThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("ServerlessRuleCpuShrinkThreshold")]
            [Validation(Required=false)]
            public string ServerlessRuleCpuShrinkThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServerlessRuleMode")]
            [Validation(Required=false)]
            public string ServerlessRuleMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B7BFB11-C077-4FE3-B051-F69CEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
