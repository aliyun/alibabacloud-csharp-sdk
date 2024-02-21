// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableAutoResourceOptimizeRulesResponseBody : TeaModel {
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
        public DisableAutoResourceOptimizeRulesResponseBodyData Data { get; set; }
        public class DisableAutoResourceOptimizeRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The number of database instances for which the automatic tablespace fragment recycling feature failed to be disabled.
            /// </summary>
            [NameInMap("ConfigFailInstanceCount")]
            [Validation(Required=false)]
            public long? ConfigFailInstanceCount { get; set; }

            /// <summary>
            /// The list of database instances for which the automatic tablespace fragment recycling feature failed to be disabled.
            /// </summary>
            [NameInMap("ConfigFailInstanceList")]
            [Validation(Required=false)]
            public List<DisableAutoResourceOptimizeRulesResponseBodyDataConfigFailInstanceList> ConfigFailInstanceList { get; set; }
            public class DisableAutoResourceOptimizeRulesResponseBodyDataConfigFailInstanceList : TeaModel {
                /// <summary>
                /// Indicates whether the automatic tablespace fragment recycling feature is disabled. Valid values:
                /// 
                /// * **true**
                /// 
                /// * **false**
                /// </summary>
                [NameInMap("ConfigSuccess")]
                [Validation(Required=false)]
                public bool? ConfigSuccess { get; set; }

                /// <summary>
                /// The error message returned if the request failed.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// The number of database instances for which the automatic tablespace fragment recycling feature is disabled.
            /// </summary>
            [NameInMap("ConfigSuccessInstanceCount")]
            [Validation(Required=false)]
            public long? ConfigSuccessInstanceCount { get; set; }

            /// <summary>
            /// The list of database instances for which the automatic tablespace fragment recycling feature is disabled.
            /// </summary>
            [NameInMap("ConfigSuccessInstanceList")]
            [Validation(Required=false)]
            public List<DisableAutoResourceOptimizeRulesResponseBodyDataConfigSuccessInstanceList> ConfigSuccessInstanceList { get; set; }
            public class DisableAutoResourceOptimizeRulesResponseBodyDataConfigSuccessInstanceList : TeaModel {
                /// <summary>
                /// Indicates whether the automatic tablespace fragment recycling feature is disabled. Valid values:
                /// 
                /// * **true**
                /// 
                /// * **false**
                /// </summary>
                [NameInMap("ConfigSuccess")]
                [Validation(Required=false)]
                public bool? ConfigSuccess { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// The total number of database instances.
            /// </summary>
            [NameInMap("TotalInstanceCount")]
            [Validation(Required=false)]
            public long? TotalInstanceCount { get; set; }

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
