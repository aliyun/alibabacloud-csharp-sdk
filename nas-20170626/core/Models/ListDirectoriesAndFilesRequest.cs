// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query only directories.
        /// 
        /// Valid values:
        /// 
        /// *   false (default): queries both directories and files.
        /// *   true: queries only directories.
        /// 
        /// >  If you set the StorageType parameter to All, you must set the DirectoryOnly parameter to true.
        /// </summary>
        [NameInMap("DirectoryOnly")]
        [Validation(Required=false)]
        public bool? DirectoryOnly { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The maximum number of directories or files to include in the results of each query.
        /// 
        /// Valid values: 10 to 128.
        /// 
        /// Default value: 100.
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

        /// <summary>
        /// The absolute path of the directory.
        /// 
        /// The path must start with a forward slash (/) and must be a path that exists in the mount target.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The storage class.
        /// 
        /// *   InfrequentAccess: the Infrequent Access (IA) storage class.
        /// *   Archive: the Archive storage class.
        /// *   All: all stored data.
        /// 
        /// >  If you set the StorageType parameter to All, you must set the DirectoryOnly parameter to true.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
