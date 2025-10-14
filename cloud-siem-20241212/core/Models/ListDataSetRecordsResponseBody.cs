// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSetRecordsResponseBody : TeaModel {
        [NameInMap("DataSetRecords")]
        [Validation(Required=false)]
        public List<ListDataSetRecordsResponseBodyDataSetRecords> DataSetRecords { get; set; }
        public class ListDataSetRecordsResponseBodyDataSetRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1658974643000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataset-t8ha6p7k61rmniqw****</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public string DataSetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lmftest</para>
            /// </summary>
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>124566</para>
            /// </summary>
            [NameInMap("DataSetRecordId")]
            [Validation(Required=false)]
            public string DataSetRecordId { get; set; }

            [NameInMap("DataSetRecordValues")]
            [Validation(Required=false)]
            public string DataSetRecordValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1658974643000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
