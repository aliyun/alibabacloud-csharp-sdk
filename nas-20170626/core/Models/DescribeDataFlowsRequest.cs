// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// *   The IDs of CPFS file systems must start with `cpfs-`. Example: cpfs-125487\\*\\*\\*\\*.
        /// *   The IDs of CPFS for LINGJUN file systems must start with `bmcpfs-`. Example: bmcpfs-0015\\*\\*\\*\\*.
        /// 
        /// >  CPFS file systems are available only on the China site (aliyun.com).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The filter that is used to query data flows.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowsRequestFilters> Filters { get; set; }
        public class DescribeDataFlowsRequestFilters : TeaModel {
            /// <summary>
            /// The filter name. Valid values:
            /// 
            /// *   DataFlowIds: filters data flows by data flow ID.
            /// *   FsetIds: filters data flows by fileset ID.
            /// *   FileSystemPath: filters data flows based on the path of a fileset in a CPFS file system.
            /// *   SourceStorage: filters data flows based on the access path of the source storage.
            /// *   ThroughputList: filters data flows based on data flow throughput.
            /// *   Description: filters data flows based on the fileset description.
            /// *   Status: filters data flows based on data flow status.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The filter value. This parameter does not support wildcards.
            /// 
            /// *   If Key is set to DataFlowIds, set Value to a data flow ID or a part of the data flow ID. You can specify a data flow ID or a group of data flow IDs. You can specify a maximum of 10 data flow IDs. Example: `dfid-12345678` or `dfid-12345678,dfid-12345679`.
            /// *   If Key is set to FsetIds, set Value to a fileset ID or a part of the fileset ID. You can specify a fileset ID or a group of fileset IDs. You can specify a maximum of 10 fileset IDs. Example: `fset-12345678` or `fset-12345678,fset-12345679`.
            /// *   If Key is set to FileSystemPath, set Value to the path or a part of the path of a fileset in a CPFS file system. The value of the parameter must be 1 to 1,024 characters in length.
            /// *   If Key is set to SourceStorage, set Value to the access path or a part of the access path of the source storage. The path can be up to 1,024 characters in length.
            /// *   If Key is set to ThroughputList, set Value to the data flow throughput. Combined query is supported.
            /// *   If Key is set to Description, set Value to a data flow description or a part of the data flow description.
            /// *   If Key is set to Status, set Value to the data flow status.
            /// *   If Key is set to SourceStoragePath, set Value to the access path or a part of the access path of the source storage. The path can be up to 1,024 characters in length.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of results for each query.
        /// 
        /// Valid values: 10 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
