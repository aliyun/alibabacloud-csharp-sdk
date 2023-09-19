// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorSLSGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The queried Logstore groups.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorSLSGroupResponseBodyList> List { get; set; }
        public class DescribeHybridMonitorSLSGroupResponseBodyList : TeaModel {
            /// <summary>
            /// The time when the Logstore group was created.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The configurations of the Logstore group.
            /// </summary>
            [NameInMap("SLSGroupConfig")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig> SLSGroupConfig { get; set; }
            public class DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig : TeaModel {
                /// <summary>
                /// The Logstore.
                /// </summary>
                [NameInMap("SLSLogstore")]
                [Validation(Required=false)]
                public string SLSLogstore { get; set; }

                /// <summary>
                /// The Simple Log Service project.
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                /// <summary>
                /// The member ID.
                /// 
                /// **Description** This parameter is returned when you call the operation by using an administrative account.
                /// </summary>
                [NameInMap("SLSUserId")]
                [Validation(Required=false)]
                public string SLSUserId { get; set; }

            }

            /// <summary>
            /// The description of the Logstore group.
            /// </summary>
            [NameInMap("SLSGroupDescription")]
            [Validation(Required=false)]
            public string SLSGroupDescription { get; set; }

            /// <summary>
            /// The name of the Logstore group.
            /// </summary>
            [NameInMap("SLSGroupName")]
            [Validation(Required=false)]
            public string SLSGroupName { get; set; }

            /// <summary>
            /// The time when the Logstore group was modified.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
