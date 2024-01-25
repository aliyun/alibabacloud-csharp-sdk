// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetListResponseBody : TeaModel {
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
            /// The ID of the dataset.
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// The name of the dataset.
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// The type of the dataset. Valid values:
            /// 
            /// *   JWT_BLOCKING: a JSON Web Token (JWT) blacklist
            /// *   IP_WHITELIST_CIDR: an IP address whitelist
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

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDatasetListResponseBodyDatasetInfoListTags> Tags { get; set; }
            public class DescribeDatasetListResponseBodyDatasetInfoListTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
