// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The continuation token from the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <para>The data service ID.</para>
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
        /// <para>The training mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sft</b>: Supervised Fine-Tuning (SFT).</para>
        /// </description></item>
        /// <item><description><para><b>grpo</b>: Reinforcement Learning (RL).</para>
        /// </description></item>
        /// <item><description><para><b>text</b>: Text generation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stf</para>
        /// </summary>
        [NameInMap("DatasetMode")]
        [Validation(Required=false)]
        public string DatasetMode { get; set; }

        /// <summary>
        /// <para>The dataset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>train</b>: The training set.</para>
        /// </description></item>
        /// <item><description><para><b>eval</b>: The evaluation set.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>An array of dataset objects.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterDatasetsResponseBodyDatasets> Datasets { get; set; }
        public class DescribeAIDBClusterDatasetsResponseBodyDatasets : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcs-2ze22***-q7***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The file size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2845904</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <para>The time the file was created, in UTC and formatted as ISO 8601.</para>
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
            /// <para>The dataset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>train</b>: The training set.</para>
            /// </description></item>
            /// <item><description><para><b>eval</b>: The evaluation set.</para>
            /// </description></item>
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
            /// <para>The time the file was last modified, in UTC and formatted as ISO 8601.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-06T06:50:43Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_ai/datasets/train/sft/dataset01/train-***.json</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The storage type. The only valid value is:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The training mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>sft</b>: Supervised Fine-Tuning (SFT).</para>
            /// </description></item>
            /// <item><description><para><b>grpo</b>: Reinforcement Learning (RL).</para>
            /// </description></item>
            /// <item><description><para><b>text</b>: Text generation.</para>
            /// </description></item>
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
        /// <para>The total number of files in the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public string FileCount { get; set; }

        /// <summary>
        /// <para>Indicates if more datasets are available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: More datasets are available.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: All datasets have been listed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The token for retrieving the next page of results. This parameter is returned only if <c>IsTruncated</c> is <c>true</c>.</para>
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
        /// <para>The relative DB cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of datasets.</para>
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
