// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must make sure that the value is unique among different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conflict policy for files with the same name.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SKIP_THE_FILE: skips files with the same name.</description></item>
        /// <item><description>KEEP_LATEST: compares the update time and retains the latest version.</description></item>
        /// <item><description>OVERWRITE_EXISTING: forcibly overwrites files with the same name.<remarks>
        /// <para>This parameter is required when the file system type is CPFS for Lingjun.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SKIP_THE_FILE</para>
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of the folder if the folder does not exist.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables automatic creation of the folder.</description></item>
        /// <item><description>false: Disables automatic creation of the folder.
        /// Default value: false.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect when TaskAction is set to Import.</description></item>
        /// <item><description>This parameter is supported only in CPFS for Lingjun 2.6.0 and later.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateDirIfNotExist")]
        [Validation(Required=false)]
        public bool? CreateDirIfNotExist { get; set; }

        /// <summary>
        /// <para>The ID of the data flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>The type of data operated by the data flow task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Metadata: the metadata of files, including attributes such as timestamp, ownership, and permission. If you select Metadata, only the metadata of the files is imported. You can only view the files. When you access the file data, the data is loaded on demand from the source storage.</description></item>
        /// <item><description>Data: the data blocks of files.</description></item>
        /// <item><description>MetaAndData: the metadata and data blocks of files.<remarks>
        /// <para>When TaskAction is set to Evict, the DataType parameter is required.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Metadata</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The source directory of the data.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must start and end with a forward slash (/).</description></item>
        /// <item><description>You can specify only one directory at a time.</description></item>
        /// <item><description>When TaskAction is set to Export, the directory must be a relative path within FileSystemPath.</description></item>
        /// <item><description>When TaskAction is set to Import, the directory must be a relative path within SourceStoragePath.</description></item>
        /// <item><description>When TaskAction is set to StreamExport, the directory must be a relative path within FileSystemPath.</description></item>
        /// <item><description>When TaskAction is set to StreamImport, the directory must be a relative path within SourceStoragePath.<remarks>
        /// <para>StreamImport and StreamExport are supported only in CPFS for Lingjun 2.6.0 and later.
        /// The Directory, EntryList, and TransferFileListPath parameters are mutually exclusive. You can specify only one of them.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/path_in_cpfs/</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the creation request.</para>
        /// <para>A dry run helps you check parameter validity and verify inventory. It does not actually create the instance or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request and does not create the instance. The system checks whether required parameters are specified, the request format, business limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the HTTP status code 200 is returned, but TaskId is empty.</description></item>
        /// <item><description>false: Sends a normal request and directly creates the instance after the check succeeds.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The destination directory mapped by the data flow task.
        /// Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must start and end with a forward slash (/). The value cannot contain /../.</description></item>
        /// <item><description>The value must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>You can specify only one directory at a time.</description></item>
        /// <item><description>When TaskAction is set to Export, the directory must be a relative path within SourceStoragePath.</description></item>
        /// <item><description>When TaskAction is set to Import, the directory must be a relative path within FileSystemPath.</description></item>
        /// <item><description>When TaskAction is set to StreamExport, the directory must be a relative path within SourceStoragePath.</description></item>
        /// <item><description>When TaskAction is set to StreamImport, the directory must be a relative path within FileSystemPath.<remarks>
        /// <para>StreamImport and StreamExport are supported only in CPFS for Lingjun 2.6.0 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/path_in_cpfs/</para>
        /// </summary>
        [NameInMap("DstDirectory")]
        [Validation(Required=false)]
        public string DstDirectory { get; set; }

        /// <summary>
        /// <para>The list of files for the data flow task to execute.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The total length of the file list must be less than 64 KB.</description></item>
        /// <item><description>The file list must be in JSON format.</description></item>
        /// <item><description>The path of a single file must be 1 to 1,023 characters in length and must start with a forward slash (/).</description></item>
        /// <item><description>When TaskAction is set to Import, each element in the list represents an OSS object name.</description></item>
        /// <item><description>When TaskAction is set to Export, each element in the list represents a CPFS file path.<remarks>
        /// <para>The Directory, EntryList, and TransferFileListPath parameters are mutually exclusive. You can specify only one of them.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/path_in_cpfs/file1&quot;, &quot;/path_in_cpfs/file2&quot;]</para>
        /// </summary>
        [NameInMap("EntryList")]
        [Validation(Required=false)]
        public string EntryList { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-0015\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>Filters the directories under the specified directory and transfers the content of the folders within the filtered directories.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the Directory parameter is specified.</description></item>
        /// <item><description>The path of a single folder must be 1 to 1,023 characters in length, must start and end with a forward slash (/), and cannot exceed 3,000 characters in total length.</description></item>
        /// <item><description>Only CPFS for Lingjun supports this feature.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/test/&quot;,&quot;/test1/&quot;]</para>
        /// </summary>
        [NameInMap("Includes")]
        [Validation(Required=false)]
        public string Includes { get; set; }

        /// <summary>
        /// <para>The ID of the source data flow task. If you specify SrcTaskId, you must enter a data flow task ID. The system copies the TaskAction, DataType, and EntryList parameters from the specified data flow task. You do not need to specify these parameters separately.</para>
        /// <remarks>
        /// <para>Streaming data flow tasks are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>task-29ee8e890f45****</para>
        /// </summary>
        [NameInMap("SrcTaskId")]
        [Validation(Required=false)]
        public string SrcTaskId { get; set; }

        /// <summary>
        /// <para>The type of the data stream node.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Import: performs data import of specified data from the source storage to CPFS.</description></item>
        /// <item><description>Export: exports specified data from CPFS to the source storage.</description></item>
        /// <item><description>StreamImport: imports specified data in batches from the source storage to CPFS.</description></item>
        /// <item><description>StreamExport: performs batch export of specified data from CPFS to the source storage.</description></item>
        /// <item><description>Evict: releases the data blocks of files in CPFS. After the release, only the metadata of the files is retained in CPFS. You can still query the files, but the data blocks are purged and do not occupy storage capacity in CPFS. When you access the file data, the data is loaded on demand from the source storage.</description></item>
        /// <item><description>Inventory: obtains the checklist of files managed by data streams in CPFS. This provides the cache status of the files in the data streams.<remarks>
        /// <para>CPFS for Lingjun supports only Import, Export, StreamImport, and StreamExport. StreamImport and StreamExport are supported only in CPFS for Lingjun 2.6.0 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Import</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The OSS directory. Data is synchronized based on the content of the CSV file in the OSS directory. Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The value must start and end with a forward slash (/).</para>
        /// </description></item>
        /// <item><description><para>The value is case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>The value must be 1 to 1,023 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The value must be encoded in UTF-8.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The TransferFileListPath, Directory, and EntryList parameters are mutually exclusive. You can specify only one of them.</description></item>
        /// <item><description>This parameter must be an actual path in OSS. The *.csv files under the path are stored in OSS.</description></item>
        /// <item><description>TransferFileListPath supports only the Import and Export operations.</description></item>
        /// <item><description>In the Import scenario, the files or directories specified in the CSV file are imported from OSS to CPFS.</description></item>
        /// <item><description>In the Export scenario, the files or directories specified in the CSV file are exported from CPFS to OSS.</description></item>
        /// <item><description>The CSV file must contain the Name and Type columns. Name is a relative path. Type supports two values: dir and file. If Type is set to dir, the Name suffix must end with a forward slash (/).</description></item>
        /// <item><description>Only CPFS for Lingjun supports this feature.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/test_oss_path/</para>
        /// </summary>
        [NameInMap("TransferFileListPath")]
        [Validation(Required=false)]
        public string TransferFileListPath { get; set; }

    }

}
