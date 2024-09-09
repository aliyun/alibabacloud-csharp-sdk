// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowTaskRequest : TeaModel {
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
        /// The conflict policy for files with the same name. Valid values:
        /// 
        /// *   SKIP_THE_FILE: skips files with the same name.
        /// *   KEEP_LATEST: compares the update time and keeps the latest version.
        /// *   OVERWRITE_EXISTING: forcibly overwrites the existing file.
        /// 
        /// >  This parameter does not take effect for CPFS file systems.
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        [NameInMap("CreateDirIfNotExist")]
        [Validation(Required=false)]
        public bool? CreateDirIfNotExist { get; set; }

        /// <summary>
        /// The dataflow ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// The type of data on which operations are performed by the dataflow task.
        /// 
        /// Valid values:
        /// 
        /// *   Metadata: the metadata of a file, including the timestamp, ownership, and permission information of the file. If you select Metadata, only the metadata of the file is imported. You can only query the file. When you access the file data, the file is loaded from the source storage as required.
        /// *   Data: the data blocks of a file.
        /// *   MetaAndData: the metadata and data blocks of the file.
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// The directory in which the data flow task is executed.
        /// 
        /// Limits:
        /// 
        /// *   The directory must be 1 to 1,023 characters in length.
        /// *   The directory must be encoded in UTF-8.
        /// *   The directory must start and end with a forward slash (/).
        /// *   Only one directory can be listed at a time.
        /// *   If the TaskAction parameter is set to Export, the directory must be a relative path within the FileSystemPath.
        /// *   If the TaskAction parameter is set to Import, the directory must be a relative path within the SourceStoragePath.
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

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

        [NameInMap("DstDirectory")]
        [Validation(Required=false)]
        public string DstDirectory { get; set; }

        /// <summary>
        /// The list of files that are executed by the data flow task.
        /// 
        /// Limits:
        /// 
        /// *   The list must be encoded in UTF-8.
        /// *   The total length of the file list cannot exceed 64 KB.
        /// *   The file list is in JSON format.
        /// *   The path of a single file must be 1 to 1,023 characters in length and must start with a forward slash (/).
        /// *   If the TaskAction parameter is set to Import, each element in the list represents an OSS object name.
        /// *   If the TaskAction parameter is set to Export, each element in the list represents a CPFS file path.
        /// </summary>
        [NameInMap("EntryList")]
        [Validation(Required=false)]
        public string EntryList { get; set; }

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
        /// If you specify SrcTaskId, the configurations of the TaskAction, DataType, and EntryList parameters are copied from the desired dataflow task. You do not need to specify them.
        /// </summary>
        [NameInMap("SrcTaskId")]
        [Validation(Required=false)]
        public string SrcTaskId { get; set; }

        /// <summary>
        /// The type of the data flow task.
        /// 
        /// Valid values:
        /// 
        /// *   Import: imports data stored in the source storage to a CPFS file system.
        /// *   Export: exports specified data from a CPFS file system to the source storage.
        /// *   Evict: releases the data blocks of a file in a CPFS file system. After the eviction, only the metadata of the file is retained in the CPFS file system. You can still query the file. However, the data blocks of the file are cleared and do not occupy the storage space in the CPFS file system. When you access the file data, the file is loaded from the source storage as required.
        /// *   Inventory: obtains the inventory list managed by a data flow from the CPFS file system, providing the cache status of inventories in the data flow.
        /// 
        /// >  CPFS for LINGJUN supports only the Import and Export tasks.
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

    }

}
