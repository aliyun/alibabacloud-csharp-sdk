// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorSLSGroupResponseBody : TeaModel {
        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The description of the Logstore group.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorSLSGroupResponseBodyList> List { get; set; }
        public class DescribeHybridMonitorSLSGroupResponseBodyList : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The Log Service project.
            /// </summary>
            [NameInMap("SLSGroupConfig")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig> SLSGroupConfig { get; set; }
            public class DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig : TeaModel {
                /// <summary>
                /// The name of the Logstore group.
                /// </summary>
                [NameInMap("SLSLogstore")]
                [Validation(Required=false)]
                public string SLSLogstore { get; set; }

                /// <summary>
                /// The ID of the member account.
                /// 
                /// >  This parameter is returned only when you call API operations by using a management account.
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// The Logstore.
                /// </summary>
                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("SLSUserId")]
                [Validation(Required=false)]
                public string SLSUserId { get; set; }

            }

            /// <summary>
            /// The configurations of the Logstore group.
            /// </summary>
            [NameInMap("SLSGroupDescription")]
            [Validation(Required=false)]
            public string SLSGroupDescription { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("SLSGroupName")]
            [Validation(Required=false)]
            public string SLSGroupName { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The timestamp that was generated when the Logstore group was modified.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// For more information about common request parameters, see [Common parameters](~~199331~~).
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The name of the Logstore group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The keyword that is used to search for Logstore groups.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
