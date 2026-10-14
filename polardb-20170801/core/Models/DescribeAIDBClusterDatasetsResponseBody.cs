// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ContinuationToken element is included in the response if the ContinuationToken parameter is specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <para>The instance ID of the dataset management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-2zeei***</para>
        /// </summary>
        [NameInMap("DataServiceId")]
        [Validation(Required=false)]
        public string DataServiceId { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds-2ze88***</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The training mode of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sft</b>: supervised fine-tuning.</description></item>
        /// <item><description><b>grpo</b>: reinforcement learning.</description></item>
        /// <item><description><b>text</b>: text generation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stf</para>
        /// </summary>
        [NameInMap("DatasetMode")]
        [Validation(Required=false)]
        public string DatasetMode { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>train</b>: training dataset.</description></item>
        /// <item><description><b>eval</b>: evaluation dataset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>The datasets.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterDatasetsResponseBodyDatasets> Datasets { get; set; }
        public class DescribeAIDBClusterDatasetsResponseBodyDatasets : TeaModel {
            /// <summary>
            /// <para>The bucket to which the dataset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcs-2ze22***-q7***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2845904</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The time is in ISO 8601 format in UTC (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-06T06:50:43Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pds-2ze88***</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The type of the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>train</b>: training dataset.</description></item>
            /// <item><description><b>eval</b>: evaluation dataset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>train-***.json</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The last modified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-06T06:50:43Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The dataset path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_ai/datasets/train/sft/dataset01/train-***.json</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: Standard storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The training mode of the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sft</b>: supervised fine-tuning.</description></item>
            /// <item><description><b>grpo</b>: reinforcement learning.</description></item>
            /// <item><description><b>text</b>: text generation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>stf</para>
            /// </summary>
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }

        }

        /// <summary>
        /// <para>The total number of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public string FileCount { get; set; }

        /// <summary>
        /// <para>Indicates whether more datasets exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: More datasets exist.</description></item>
        /// <item><description><b>false</b>: No more datasets exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The ContinuationToken for the next listing of files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the database management service.</para>
        /// 
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
        /// <para>The total number of records. This parameter is returned only when you query a list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public string TotalRecords { get; set; }

    }

}
