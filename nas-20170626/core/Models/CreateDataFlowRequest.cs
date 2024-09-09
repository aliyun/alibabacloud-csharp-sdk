// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowRequest : TeaModel {
        /// <summary>
        /// The automatic update interval. CPFS checks whether data is updated in the directory at the interval specified by this parameter. If data is updated, CPFS starts an automatic update task. Unit: minutes.
        /// 
        /// Valid values: 10 to 525600. Default value: 10.
        /// 
        /// >  This parameter takes effect only for CPFS file systems.
        /// </summary>
        [NameInMap("AutoRefreshInterval")]
        [Validation(Required=false)]
        public long? AutoRefreshInterval { get; set; }

        /// <summary>
        /// The automatic update policy. The updated data in the source storage is imported into the CPFS file system based on the policy.
        /// 
        /// *   None (default): Updated data in the source storage is not automatically imported into the CPFS file system. You can run a data flow task to import the updated data from the source storage.
        /// *   ImportChanged: Updated data in the source storage is automatically imported into the CPFS file system.
        /// 
        /// >  This parameter takes effect only for CPFS file systems.
        /// </summary>
        [NameInMap("AutoRefreshPolicy")]
        [Validation(Required=false)]
        public string AutoRefreshPolicy { get; set; }

        /// <summary>
        /// The automatic update configurations.
        /// 
        /// >  This parameter takes effect only for CPFS file systems.
        /// </summary>
        [NameInMap("AutoRefreshs")]
        [Validation(Required=false)]
        public List<CreateDataFlowRequestAutoRefreshs> AutoRefreshs { get; set; }
        public class CreateDataFlowRequestAutoRefreshs : TeaModel {
            /// <summary>
            /// The automatic update directory. CPFS registers the data update event in the source storage, and automatically checks whether the source data in the directory is updated and imports the updated data.
            /// 
            /// This parameter is empty by default. Updated data in the source storage is not automatically imported into the CPFS file system. You must import the updated data by running a manual task.
            /// 
            /// Limits:
            /// 
            /// *   The directory must be 2 to 1,024 characters in length.
            /// *   The directory must be encoded in UTF-8.
            /// *   The directory must start and end with a forward slash (/).
            /// *   The directory must be an existing directory in the CPFS file system and must be in a fileset where the data flow is enabled.
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
        /// The directory in the CPFS for LINGJUN file system. Limits:
        /// 
        /// *   The directory must start and end with a forward slash (/).
        /// *   The directory must be an existing directory in the CPFS for LINGJUN file system.
        /// *   The directory must be 1 to 1023 characters in length.
        /// *   The directory must be encoded in UTF-8.
        /// 
        /// >  This parameter is required for CPFS for LINGJUN file systems.
        /// </summary>
        [NameInMap("FileSystemPath")]
        [Validation(Required=false)]
        public string FileSystemPath { get; set; }

        /// <summary>
        /// The fileset ID.
        /// 
        /// >  This parameter is required for CPFS file systems.
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
        /// *   storage type: Only OSS is supported.
        /// 
        /// *   path: the name of the OSS bucket. Limits:
        /// 
        ///     *   The path can contain only lowercase letters, digits, and hyphens (-). The path must start and end with a lowercase letter or digit.
        ///     *   The path can be up to 128 characters in length.
        ///     *   The path must be encoded in UTF-8.
        /// 
        /// >  The OSS bucket must be an existing bucket in the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceStorage")]
        [Validation(Required=false)]
        public string SourceStorage { get; set; }

        /// <summary>
        /// The access path in the bucket of the source storage. Limits:
        /// 
        /// *   The path must start and end with a forward slash (/).
        /// *   The path is case-sensitive.
        /// *   The path must be 1 to 1023 characters in length.
        /// *   The path must be encoded in UTF-8.
        /// 
        /// >  This parameter is required for CPFS for LINGJUN file systems.
        /// </summary>
        [NameInMap("SourceStoragePath")]
        [Validation(Required=false)]
        public string SourceStoragePath { get; set; }

        /// <summary>
        /// The maximum data flow throughput. Unit: MB/s. Valid values:
        /// 
        /// *   600
        /// *   1200
        /// *   1500
        /// 
        /// >  The data flow throughput must be less than the I/O throughput of the file system. This parameter is required for CPFS file systems.
        /// </summary>
        [NameInMap("Throughput")]
        [Validation(Required=false)]
        public long? Throughput { get; set; }

    }

}
