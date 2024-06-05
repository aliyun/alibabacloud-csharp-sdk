// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The filter that is used to query filesets.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeFilesetsRequestFilters> Filters { get; set; }
        public class DescribeFilesetsRequestFilters : TeaModel {
            /// <summary>
            /// The filter name. Valid values:
            /// 
            /// *   FsetIds: filters filesets by fileset ID.
            /// *   FileSystemPath: filters filesets based on the path of a fileset in a CPFS file system.
            /// *   Description: filters filesets based on the fileset description.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The filter value. This parameter does not support wildcards.
            /// 
            /// *   If Key is set to FsetIds, set Value to a fileset ID or a part of the fileset ID. You can specify a fileset ID or a group of fileset IDs. You can specify a maximum of 10 fileset IDs. Example: `fset-12345678` or `fset-12345678,fset-12345679`.
            /// *   If Key is set to FileSystemPath, set Value to the path or a part of the path of a fileset in a CPFS file system. The value must be 2 to 1,024 characters in length. The value must be encoded in UTF-8.
            /// *   If Key is set to Description, set Value to a fileset description or a part of the fileset description.
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
