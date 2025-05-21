// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned dataset information. It is an array consisting of datasetinfo.</para>
        /// </summary>
        [NameInMap("DatasetInfoList")]
        [Validation(Required=false)]
        public List<DescribeDatasetListResponseBodyDatasetInfoList> DatasetInfoList { get; set; }
        public class DescribeDatasetListResponseBodyDatasetInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the dataset was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6304ce6b4ae6453f********</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DatasetName</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>The dataset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>JWT_BLOCKING : a JSON Web Token (JWT) blacklist</description></item>
            /// <item><description>IP_WHITELIST_CIDR : an IP address whitelist</description></item>
            /// <item><description>PARAMETER_ACCESS: a list of parameters for parameter-based access control</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IP_WHITELIST_CIDR</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the dataset was last modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDatasetListResponseBodyDatasetInfoListTags> Tags { get; set; }
            public class DescribeDatasetListResponseBodyDatasetInfoListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D403C6E6-21B3-5B78-82DA-E3B6********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
