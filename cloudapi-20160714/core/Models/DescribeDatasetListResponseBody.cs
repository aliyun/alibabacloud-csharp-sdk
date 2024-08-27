// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetListResponseBody : TeaModel {
        /// <summary>
        /// The returned dataset information. It is an array consisting of datasetinfo.
        /// </summary>
        [NameInMap("DatasetInfoList")]
        [Validation(Required=false)]
        public List<DescribeDatasetListResponseBodyDatasetInfoList> DatasetInfoList { get; set; }
        public class DescribeDatasetListResponseBodyDatasetInfoList : TeaModel {
            /// <summary>
            /// The time when the dataset was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The dataset ID.
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// The dataset name.
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// The dataset type. Valid values:
            /// 
            /// *   JWT_BLOCKING : a JSON Web Token (JWT) blacklist
            /// *   IP_WHITELIST_CIDR : an IP address whitelist
            /// *   PARAMETER_ACCESS: a list of parameters for parameter-based access control
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// The time when the dataset was last modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 标签
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDatasetListResponseBodyDatasetInfoListTags> Tags { get; set; }
            public class DescribeDatasetListResponseBodyDatasetInfoListTags : TeaModel {
                /// <summary>
                /// 标签的键
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 标签值
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
