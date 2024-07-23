// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoResourceOptimizeRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoResourceOptimizeRulesResponseBodyData Data { get; set; }
        public class GetAutoResourceOptimizeRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of database instances for which the automatic fragment recycling feature is currently enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableAutoResourceOptimizeCount")]
            [Validation(Required=false)]
            public long? EnableAutoResourceOptimizeCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic fragment recycling feature is currently enabled.</para>
            /// </summary>
            [NameInMap("EnableAutoResourceOptimizeList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataEnableAutoResourceOptimizeList> EnableAutoResourceOptimizeList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataEnableAutoResourceOptimizeList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic fragment recycling feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// <para>Indicates whether DAS Enterprise Edition is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// <para>The minimum storage usage of a single physical table for which the automatic fragment recycling feature is enabled. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of database instances for which the automatic fragment recycling feature is enabled and DAS Enterprise Edition is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HasEnableRuleButNotDasProCount")]
            [Validation(Required=false)]
            public long? HasEnableRuleButNotDasProCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic fragment recycling feature is enabled and DAS Enterprise Edition is disabled.</para>
            /// <remarks>
            /// <para> Automatic fragment recycling tasks are run on this type of database instances only if DAS Enterprise Edition is enabled for the database instances again.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("HasEnableRuleButNotDasProList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataHasEnableRuleButNotDasProList> HasEnableRuleButNotDasProList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataHasEnableRuleButNotDasProList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic fragment recycling feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// <para>Indicates whether DAS Enterprise Edition is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze9xrhze0709****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// <para>The minimum storage usage of a single physical table for which the automatic fragment recycling feature is enabled. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of database instances that do not exist or for which the automatic fragment recycling feature has never been enabled.</para>
            /// <remarks>
            /// <para> If a database instance does not exist, the instance has been released or the specified instance ID is invalid.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NeverEnableAutoResourceOptimizeOrReleasedInstanceCount")]
            [Validation(Required=false)]
            public long? NeverEnableAutoResourceOptimizeOrReleasedInstanceCount { get; set; }

            /// <summary>
            /// <para>The database instances that do not exist or for which the automatic fragment recycling feature has never been enabled.</para>
            /// </summary>
            [NameInMap("NeverEnableAutoResourceOptimizeOrReleasedInstanceIdList")]
            [Validation(Required=false)]
            public List<string> NeverEnableAutoResourceOptimizeOrReleasedInstanceIdList { get; set; }

            /// <summary>
            /// <para>The number of database instances for which the automatic fragment recycling feature has been enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalAutoResourceOptimizeRulesCount")]
            [Validation(Required=false)]
            public long? TotalAutoResourceOptimizeRulesCount { get; set; }

            /// <summary>
            /// <para>The number of database instances for which the automatic fragment recycling feature was once enabled but is currently disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TurnOffAutoResourceOptimizeCount")]
            [Validation(Required=false)]
            public long? TurnOffAutoResourceOptimizeCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic fragment recycling feature was once enabled but is currently disabled.</para>
            /// </summary>
            [NameInMap("TurnOffAutoResourceOptimizeList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataTurnOffAutoResourceOptimizeList> TurnOffAutoResourceOptimizeList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataTurnOffAutoResourceOptimizeList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic fragment recycling feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>:</description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// <para>Indicates whether DAS Enterprise Edition is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2vc54m2a6pd6p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// <para>The minimum storage usage of a single physical table for which the automatic fragment recycling feature is enabled. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
