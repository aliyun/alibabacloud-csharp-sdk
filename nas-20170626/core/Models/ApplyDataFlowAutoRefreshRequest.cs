// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ApplyDataFlowAutoRefreshRequest : TeaModel {
        /// <summary>
        /// The automatic update interval. CPFS checks whether data is updated in the directory at the interval specified by this parameter. If data is updated, CPFS starts an automatic update task. Unit: minutes.
        /// 
        /// Valid values: 5 to 526600. Default value: 10.
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// The automatic update policy. The updated data in the source storage is imported into the CPFS file system based on the policy. Valid values:
        /// 
        /// *   None (default): Updated data in the source storage is not automatically imported into the CPFS file system. You can run a dataflow task to import the updated data from the source storage.
        /// *   ImportChanged: Updated data in the source storage is automatically imported into the CPFS file system.
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// The automatic update configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AutoRefreshs")]
        [Validation(Required=false)]
        public List<ApplyDataFlowAutoRefreshRequestAutoRefreshs> AutoRefreshs { get; set; }
        public class ApplyDataFlowAutoRefreshRequestAutoRefreshs : TeaModel {
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
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RefreshPath")]
            [Validation(Required=false)]
            public string RefreshPath { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence?](https://help.aliyun.com/document_detail/25693.html)
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the request ID as the client token. The value of RequestId may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The dataflow ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run.
        /// 
        /// During the dry run, the system checks whether the request parameters are valid and whether the requested resources are available. During the dry run, no file system is created and no fee is incurred.
        /// 
        /// Valid values:
        /// 
        /// *   true: performs a dry run. The system checks the required parameters, request syntax, limits, and available NAS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the FileSystemId parameter.
        /// *   false (default): performs a dry run and sends the request. If the request passes the dry run, a file system is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
