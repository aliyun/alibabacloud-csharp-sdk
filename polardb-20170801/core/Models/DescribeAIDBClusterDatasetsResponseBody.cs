// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pcs-2zeei***</para>
        /// </summary>
        [NameInMap("DataServiceId")]
        [Validation(Required=false)]
        public string DataServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pds-2ze88***</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stf</para>
        /// </summary>
        [NameInMap("DatasetMode")]
        [Validation(Required=false)]
        public string DatasetMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterDatasetsResponseBodyDatasets> Datasets { get; set; }
        public class DescribeAIDBClusterDatasetsResponseBodyDatasets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pcs-2ze22***-q7***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2845904</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-06T06:50:43Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pds-2ze88***</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>train-***.json</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-06T06:50:43Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polardb_ai/datasets/train/sft/dataset01/train-***.json</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stf</para>
            /// </summary>
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public string FileCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public string TotalRecords { get; set; }

    }

}
