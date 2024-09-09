// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsResponseBody : TeaModel {
        /// <summary>
        /// The details about data flows.
        /// </summary>
        [NameInMap("DataFlowInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowsResponseBodyDataFlowInfo DataFlowInfo { get; set; }
        public class DescribeDataFlowsResponseBodyDataFlowInfo : TeaModel {
            [NameInMap("DataFlow")]
            [Validation(Required=false)]
            public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlow> DataFlow { get; set; }
            public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlow : TeaModel {
                /// <summary>
                /// The details about automatic update policies.
                /// 
                /// >  Only CPFS supports this parameter.
                /// </summary>
                [NameInMap("AutoRefresh")]
                [Validation(Required=false)]
                public DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh AutoRefresh { get; set; }
                public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefresh : TeaModel {
                    [NameInMap("AutoRefresh")]
                    [Validation(Required=false)]
                    public List<DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh> AutoRefresh { get; set; }
                    public class DescribeDataFlowsResponseBodyDataFlowInfoDataFlowAutoRefreshAutoRefresh : TeaModel {
                        /// <summary>
                        /// The automatic update directory. CPFS automatically checks whether the source data only in the directory is updated and imports the updated data.
                        /// 
                        /// Limits:
                        /// 
                        /// *   The directory must be 2 to 1,024 characters in length.
                        /// *   The directory must be encoded in UTF-8.
                        /// *   The directory must start and end with a forward slash (/).
                        /// 
                        /// >  The directory must be an existing directory in the CPFS file system and must be in a fileset where the dataflow is enabled.
                        /// </summary>
                        [NameInMap("RefreshPath")]
                        [Validation(Required=false)]
                        public string RefreshPath { get; set; }

                    }

                }

                /// <summary>
                /// The automatic update interval. CPFS checks whether data is updated in the directory at the interval specified by this parameter. If data is updated, CPFS starts an automatic update task. Unit: minutes.
                /// 
                /// Valid values: 5 to 526600. Default value: 10.
                /// 
                /// >  Only CPFS supports this parameter.
                /// </summary>
                [NameInMap("AutoRefreshInterval")]
                [Validation(Required=false)]
                public long? AutoRefreshInterval { get; set; }

                /// <summary>
                /// The automatic update policy. The updated data in the source storage is imported into the CPFS file system based on the policy. Valid values:
                /// 
                /// *   None: Updated data in the source storage is not automatically imported into the CPFS file system. You can run a data flow task to import the updated data from the source storage.
                /// *   ImportChanged: Updated data in the source storage is automatically imported into the CPFS file system.
                /// 
                /// >  Only CPFS supports this parameter.
                /// </summary>
                [NameInMap("AutoRefreshPolicy")]
                [Validation(Required=false)]
                public string AutoRefreshPolicy { get; set; }

                /// <summary>
                /// The time when the fileset was created.
                /// 
                /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The dataflow ID.
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// The description of the dataflow.
                /// 
                /// Limits:
                /// 
                /// *   The description must be 2 to 128 characters in length.
                /// *   The description must start with a letter but cannot start with `http://` or `https://`.
                /// *   The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The error message returned. Valid values:
                /// 
                /// *   None (default): The dataflow status is normal.
                /// *   SourceStorageUnreachable: The access path of the source storage is not found.
                /// *   ThroughputTooLow: The dataflow throughput is low.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The directory of the fileset in the CPFS file system.
                /// 
                /// Limits:
                /// 
                /// *   The directory must be 2 to 1,024 characters in length.
                /// *   The directory must be encoded in UTF-8.
                /// *   The directory must start and end with a forward slash (/).
                /// *   The directory must be a fileset directory in the CPFS file system.
                /// 
                /// >  Only CPFS supports this parameter.
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// The description of the automatic update.
                /// 
                /// >  Only CPFS supports this parameter.
                /// </summary>
                [NameInMap("FsetDescription")]
                [Validation(Required=false)]
                public string FsetDescription { get; set; }

                /// <summary>
                /// The fileset ID.
                /// </summary>
                [NameInMap("FsetId")]
                [Validation(Required=false)]
                public string FsetId { get; set; }

                /// <summary>
                /// The type of security mechanism for the source storage. This parameter must be specified if the source storage is accessed with a security mechanism. Valid values:
                /// 
                /// *   None (default): The source storage can be accessed without a security mechanism.
                /// *   SSL: The source storage must be accessed with an SSL certificate.
                /// </summary>
                [NameInMap("SourceSecurityType")]
                [Validation(Required=false)]
                public string SourceSecurityType { get; set; }

                /// <summary>
                /// The access path of the source storage. Format: `<storage type>://<path>`.
                /// 
                /// Parameters:
                /// 
                /// *   storage type: Only Object Storage Service (OSS) is supported.
                /// 
                /// *   path: the name of the OSS bucket.
                /// 
                ///     *   The name can contain only lowercase letters, digits, and hyphens (-). The name must start and end with a lowercase letter or digit.
                ///     *   The name must be 8 to 128 characters in length.
                ///     *   The name must be encoded in UTF-8.
                ///     *   The name cannot start with http:// or https://.
                /// 
                /// >  The OSS bucket must be an existing bucket in the region.
                /// </summary>
                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// The access path in the bucket of the source storage.
                /// 
                /// >  Only CPFS for LINGJUN supports this parameter.
                /// </summary>
                [NameInMap("SourceStoragePath")]
                [Validation(Required=false)]
                public string SourceStoragePath { get; set; }

                /// <summary>
                /// The dataflow status. Valid values:
                /// 
                /// *   Starting: The dataflow is being created or enabled.
                /// *   Running: The dataflow has been created and is running properly.
                /// *   Updating: The dataflow is being modified. For example, the dataflow throughput is increased and the automatic update interval is modified.
                /// *   Deleting: The dataflow is being deleted.
                /// *   Stopping: The dataflow is being disabled.
                /// *   Stopped: The dataflow has been disabled.
                /// *   Misconfigured: The dataflow configuration is abnormal. For example, the source storage is inaccessible, and the automatic update cannot be completed due to low dataflow throughput.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The maximum dataflow throughput. Unit: MB/s. Valid values:
                /// 
                /// *   600
                /// *   1,200
                /// *   1,500
                /// 
                /// >  The dataflow throughput must be less than the I/O throughput of the file system.
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                /// <summary>
                /// The time when the fileset was last updated.
                /// 
                /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
