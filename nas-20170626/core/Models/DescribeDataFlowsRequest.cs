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
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The filter that is used to query dataflows.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowsRequestFilters> Filters { get; set; }
        public class DescribeDataFlowsRequestFilters : TeaModel {
            /// <summary>
            /// The filter name. Valid values:
            /// 
            /// *   DataFlowIds: filters dataflows by dataflow ID.
            /// *   FsetIds: filters dataflows by fileset ID.
            /// *   FileSystemPath: filters dataflows based on the path of a fileset in a CPFS file system.
            /// *   SourceStorage: filters dataflows based on the access path of the source storage.
            /// *   ThroughputList: filters dataflows based on dataflow throughput.
            /// *   Description: filters dataflows based on the fileset description.
            /// *   Status: filters dataflows based on dataflow status.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter. This parameter does not support wildcards.
            /// 
            /// *   If Key is set to DataFlowIds, set Value to a data flow ID or a part of the data flow ID. You can specify a dataflow ID or a group of dataflow IDs. You can specify a maximum of 10 dataflow IDs. Example: `dfid-12345678` or `dfid-12345678,dfid-12345679`.
            /// *   If Key is set to FsetIds, set Value to a fileset ID or a part of the fileset ID. You can specify a fileset ID or a group of fileset IDs. You can specify a maximum of 10 fileset IDs. Example: `fset-12345678` or `fset-12345678,fset-12345679`.
            /// *   If Key set to FileSystemPath, set Value to the path or a part of the path of a fileset in a CPFS file system. The value must be 2 to 1,024 characters in length. The value must be encoded in UTF-8.
            /// *   If Key is set to SourceStorage, set Value to the access path or a part of the access path of the source storage. The value must be 8 to 128 characters in length. The value must be encoded in UTF-8 and comply with the naming conventions of Object Storage Service (OSS) buckets.
            /// *   If Key is set to ThroughputList, set Value to the dataflow throughput. Combined query is supported.
            /// *   If Key is set to Description, set Value to a dataflow description or a part of the dataflow description.
            /// *   If Key is set to Status, set Value to the dataflow status.
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
