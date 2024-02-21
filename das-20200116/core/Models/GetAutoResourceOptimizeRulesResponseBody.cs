// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoResourceOptimizeRulesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoResourceOptimizeRulesResponseBodyData Data { get; set; }
        public class GetAutoResourceOptimizeRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The number of database instances for which the automatic fragment recycling feature is currently enabled.
            /// </summary>
            [NameInMap("EnableAutoResourceOptimizeCount")]
            [Validation(Required=false)]
            public long? EnableAutoResourceOptimizeCount { get; set; }

            /// <summary>
            /// The database instances for which the automatic fragment recycling feature is currently enabled.
            /// </summary>
            [NameInMap("EnableAutoResourceOptimizeList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataEnableAutoResourceOptimizeList> EnableAutoResourceOptimizeList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataEnableAutoResourceOptimizeList : TeaModel {
                /// <summary>
                /// Indicates whether the automatic fragment recycling feature is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// Indicates whether DAS Professional Edition is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// The minimum storage usage of a single physical table for which the automatic fragment recycling feature is enabled. Unit: GB.
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the database instance.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The number of database instances for which the automatic fragment recycling feature is enabled and DAS Professional Edition is disabled.
            /// </summary>
            [NameInMap("HasEnableRuleButNotDasProCount")]
            [Validation(Required=false)]
            public long? HasEnableRuleButNotDasProCount { get; set; }

            /// <summary>
            /// The database instances for which the automatic fragment recycling feature is enabled and DAS Professional Edition is disabled.
            /// 
            /// > This type of database instance does not perform automatic fragment recycling tasks until DAS Professional Edition is enabled for the instances again.
            /// </summary>
            [NameInMap("HasEnableRuleButNotDasProList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataHasEnableRuleButNotDasProList> HasEnableRuleButNotDasProList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataHasEnableRuleButNotDasProList : TeaModel {
                /// <summary>
                /// Indicates whether the automatic fragment recycling feature is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// Indicates whether DAS Professional Edition is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// The minimum storage usage of a single physical table for which the automatic fragment recycling feature is enabled. Unit: GB.
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the database instance.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The number of database instances that do not exist or for which the automatic fragment recycling feature has never been enabled.
            /// 
            /// >  If a database instance does not exist, the instance has been released or the specified instance ID is invalid.
            /// </summary>
            [NameInMap("NeverEnableAutoResourceOptimizeOrReleasedInstanceCount")]
            [Validation(Required=false)]
            public long? NeverEnableAutoResourceOptimizeOrReleasedInstanceCount { get; set; }

            /// <summary>
            /// The database instances that do not exist or for which the automatic fragment recycling feature has never been enabled.
            /// </summary>
            [NameInMap("NeverEnableAutoResourceOptimizeOrReleasedInstanceIdList")]
            [Validation(Required=false)]
            public List<string> NeverEnableAutoResourceOptimizeOrReleasedInstanceIdList { get; set; }

            /// <summary>
            /// The number of database instances for which the automatic fragment recycling feature has been enabled.
            /// </summary>
            [NameInMap("TotalAutoResourceOptimizeRulesCount")]
            [Validation(Required=false)]
            public long? TotalAutoResourceOptimizeRulesCount { get; set; }

            /// <summary>
            /// The number of database instances for which the automatic fragment recycling feature was once enabled but is currently disabled.
            /// </summary>
            [NameInMap("TurnOffAutoResourceOptimizeCount")]
            [Validation(Required=false)]
            public long? TurnOffAutoResourceOptimizeCount { get; set; }

            /// <summary>
            /// The database instances for which the automatic fragment recycling feature was once enabled but is currently disabled.
            /// </summary>
            [NameInMap("TurnOffAutoResourceOptimizeList")]
            [Validation(Required=false)]
            public List<GetAutoResourceOptimizeRulesResponseBodyDataTurnOffAutoResourceOptimizeList> TurnOffAutoResourceOptimizeList { get; set; }
            public class GetAutoResourceOptimizeRulesResponseBodyDataTurnOffAutoResourceOptimizeList : TeaModel {
                /// <summary>
                /// Indicates whether the automatic fragment recycling feature is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("AutoDefragment")]
                [Validation(Required=false)]
                public bool? AutoDefragment { get; set; }

                /// <summary>
                /// Indicates whether DAS Professional Edition is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("DasProOn")]
                [Validation(Required=false)]
                public bool? DasProOn { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The fragmentation rate of a single physical table for which the automatic fragment recycling feature is enabled.
                /// </summary>
                [NameInMap("TableFragmentationRatio")]
                [Validation(Required=false)]
                public double? TableFragmentationRatio { get; set; }

                /// <summary>
                /// Indicates whether the automatic fragment recycling feature is enabled. Valid values:
                /// 
                /// true
                /// false
                /// </summary>
                [NameInMap("TableSpaceSize")]
                [Validation(Required=false)]
                public double? TableSpaceSize { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the database instance.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
