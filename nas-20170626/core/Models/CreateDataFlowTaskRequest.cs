// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The conflict policy for files with the same name. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>SKIP_THE_FILE: skips files with the same name.</description></item>
        /// <item><description>KEEP_LATEST: compares the update time and keeps the latest version.</description></item>
        /// <item><description>OVERWRITE_EXISTING: forcibly overwrites the existing file.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SKIP_THE_FILE</para>
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a directory if no directory exists. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: automatically creates a directory.</description></item>
        /// <item><description>false (default): does not automatically create a directory.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if the TaskAction parameter is set to Import.</para>
        /// </description></item>
        /// <item><description><para>Only CPFS for Lingjun V2.6.0 and later support this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateDirIfNotExist")]
        [Validation(Required=false)]
        public bool? CreateDirIfNotExist { get; set; }

        /// <summary>
        /// <para>The ID of the dataflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>The type of data on which operations are performed by the dataflow task.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Metadata: the metadata of a file, including the timestamp, ownership, and permission information of the file. If you select Metadata, only the metadata of the file is imported. You can only query the file. When you access the file data, the file is loaded from the source storage as required.</description></item>
        /// <item><description>Data: the data blocks of a file.</description></item>
        /// <item><description>MetaAndData: the metadata and data blocks of the file.</description></item>
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
        /// <item><description>The directory must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>Must be encoded in UTF-8.</description></item>
        /// <item><description>The directory must start and end with a forward slash (/).</description></item>
        /// <item><description>Only one directory can be listed at a time.</description></item>
        /// <item><description>If the TaskAction parameter is set to Export, the directory must be a relative path within the FileSystemPath.</description></item>
        /// <item><description>If the TaskAction parameter is set to Import, the directory must be a relative path within the SourceStoragePath.</description></item>
        /// <item><description>If the TaskAction parameter is set to StreamExport, the directory must be a relative path within the FileSystemPath.</description></item>
        /// <item><description>If the TaskAction parameter is set to StreamImport, the directory must be a relative path within the SourceStoragePath.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only CPFS for Lingjun V2.6.0 and later support StreamImport and StreamExport.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/path_in_cpfs/</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// <para>During the dry run, the system checks whether the request parameters are valid and whether the requested resources are available. During the dry run, no dataflow task is created and no fee is incurred.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks the required parameters, request syntax, service limits, and available Apsara File Storage NAS (NAS) resources. Otherwise, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the TaskId parameter.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, a dataflow task is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The directory mapped to the dataflow task. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The directory must start and end with a forward slash (/). The directory cannot be /../.</description></item>
        /// <item><description>The directory must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>Must be encoded in UTF-8.</description></item>
        /// <item><description>Only one directory can be listed at a time.</description></item>
        /// <item><description>If the TaskAction parameter is set to Export, the directory must be a relative path within the SourceStoragePath.</description></item>
        /// <item><description>If the TaskAction parameter is set to Import, the directory must be a relative path within the FileSystemPath.</description></item>
        /// <item><description>If the TaskAction parameter is set to StreamExport, the directory must be a relative path within the SourceStoragePath.</description></item>
        /// <item><description>If the TaskAction parameter is set to StreamImport, the directory must be a relative path within the FileSystemPath.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only CPFS for Lingjun V2.6.0 and later support StreamImport and StreamExport.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/path_in_cpfs/</para>
        /// </summary>
        [NameInMap("DstDirectory")]
        [Validation(Required=false)]
        public string DstDirectory { get; set; }

        /// <summary>
        /// <para>The list of files that are executed by the dataflow task.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The list must be encoded in UTF-8.</description></item>
        /// <item><description>The total length of the file list cannot exceed 64 KB.</description></item>
        /// <item><description>The file list is in JSON format.</description></item>
        /// <item><description>The path of a single file must be 1 to 1,023 characters in length and must start with a forward slash (/).</description></item>
        /// <item><description>If the TaskAction parameter is set to Import, each element in the list represents an OSS object name.</description></item>
        /// <item><description>If the TaskAction parameter is set to Export, each element in the list represents a CPFS file path.</description></item>
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
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for Lingjun file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-0015\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>Filters subdirectories and transfers their contents.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when the Directory parameter is specified.</para>
        /// </description></item>
        /// <item><description><para>The path length of a single folder must be 1 to 1023 characters, start and end with a forward slash (/), and the total length must not exceed 3000 characters.</para>
        /// </description></item>
        /// <item><description><para>Only CPFS for Lingjun supports this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/test/&quot;,&quot;/test1/&quot;]</para>
        /// </summary>
        [NameInMap("Includes")]
        [Validation(Required=false)]
        public string Includes { get; set; }

        /// <summary>
        /// <para>If you specify SrcTaskId, you must enter the ID of the dataflow task. The system copies the TaskAction, DataType, and EntryList parameters from the destination dataflow task. You do not need to specify them.</para>
        /// <remarks>
        /// <para> Streaming dataflow tasks are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>task-27aa8e890f45****</para>
        /// </summary>
        [NameInMap("SrcTaskId")]
        [Validation(Required=false)]
        public string SrcTaskId { get; set; }

        /// <summary>
        /// <para>Select the type of the dataflow task.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Import: imports data stored in the source storage to a CPFS file system.</description></item>
        /// <item><description>Export: exports specified data from a CPFS file system to the source storage.</description></item>
        /// <item><description>StreamImport: batch imports the specified data from the source storage to a CPFS file system.</description></item>
        /// <item><description>StreamExport: batch exports specified data from a CPFS file system to the source storage.</description></item>
        /// <item><description>Evict: releases the data blocks of a file in a CPFS file system. After the eviction, only the metadata of the file is retained in the CPFS file system. You can still query the file. However, the data blocks of the file are cleared and do not occupy the storage space in the CPFS file system. When you access the file data, the file is loaded from the source storage as required.</description></item>
        /// <item><description>Inventory: obtains the inventory list managed by a dataflow from the CPFS file system, providing the cache status of inventories in the dataflow.</description></item>
        /// </list>
        /// <remarks>
        /// <para> CPFS for Lingjun supports only Import, Export, StreamImport, and StreamExport. Only CPFS for Lingjun V2.6.0 and later support StreamImport and StreamExport.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Import</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>Specify the OSS directory and synchronize data based on the content of the CSV file in the OSS directory. Requirements:</para>
        /// <list type="bullet">
        /// <item><description>Must start and end with a forward slash (/).</description></item>
        /// <item><description>Case-sensitive.</description></item>
        /// <item><description>Must be 1 to 1023 characters in length.</description></item>
        /// <item><description>Must be encoded in UTF-8.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>TransferFileListPath,Directory, and EntryList are mutually exclusive, and only one of the three can be selected.</para>
        /// </description></item>
        /// <item><description><para>This parameter is the actual path that exists in OSS. The \*.csv file in the path is stored in OSS.</para>
        /// </description></item>
        /// <item><description><para>TransferFileListPath only supports Import and Export functions.</para>
        /// </description></item>
        /// <item><description><para>In the import scenario, the file or directory specified in the CSV file is imported from OSS to CPFS.</para>
        /// </description></item>
        /// <item><description><para>In the export scenario, the file or directory specified in the CSV file is exported from CPFS to OSS.</para>
        /// </description></item>
        /// <item><description><para>The CSV file format should include the columns Name and Type. Name refers to the relative path, while Type supports two values: dir and file. If Type is dir, the Name must end with a &quot;/&quot;.</para>
        /// </description></item>
        /// <item><description><para>Only CPFS for Lingjun supports this operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/test_oss_path/</para>
        /// </summary>
        [NameInMap("TransferFileListPath")]
        [Validation(Required=false)]
        public string TransferFileListPath { get; set; }

    }

}
