// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowTaskRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique across different requests.</para>
        /// <para><c>ClientToken</c> can contain only ASCII characters and must not exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <c>RequestId</c> of the API request as the <c>ClientToken</c>. The <c>RequestId</c> may be different for each API request.</para>
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
        /// <item><description><para>SKIP_THE_FILE: Skips files with the same name.</para>
        /// </description></item>
        /// <item><description><para>KEEP_LATEST: Compares update times and keeps the latest version.</para>
        /// </description></item>
        /// <item><description><para>OVERWRITE_EXISTING: Forcibly overwrites files with the same name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if the file system is a CPFS AI-Computing Edition instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SKIP_THE_FILE</para>
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create the directory if it does not exist.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Automatically creates the directory.</para>
        /// </description></item>
        /// <item><description><para>false (default): Does not automatically create the directory.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <c>TaskAction</c> is set to <c>Import</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only by CPFS AI-Computing Edition V2.6.0 and later.</para>
        /// </description></item>
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
        /// <para>The data type that the data flow task operates on.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Metadata: The metadata of the file, including attributes such as timestamp, ownership, and permissions. If you select <c>Metadata</c>, only the file metadata is imported. You can see the file, but when you access the file data, it is loaded from the source storage on demand.</para>
        /// </description></item>
        /// <item><description><para>Data: The data blocks of the file.</para>
        /// </description></item>
        /// <item><description><para>MetaAndData: The metadata and data blocks of the file.</para>
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
        /// <item><description><para>The length must be 1 to 1,023 characters.</para>
        /// </description></item>
        /// <item><description><para>The directory must be UTF-8 encoded.</para>
        /// </description></item>
        /// <item><description><para>The directory must start and end with a forward slash (<c>/</c>).</para>
        /// </description></item>
        /// <item><description><para>Only one directory can be specified at a time.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Export</c>, this directory must be a relative path within <c>FileSystemPath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Import</c>, this directory must be a relative path within <c>SourceStoragePath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>StreamExport</c>, this directory must be a relative path within <c>FileSystemPath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>StreamImport</c>, this directory must be a relative path within <c>SourceStoragePath</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><c>StreamImport</c> and <c>StreamExport</c> are supported only by CPFS AI-Computing Edition V2.6.0 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/path_in_cpfs/</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this creation request.</para>
        /// <para>A dry run checks parameter validity and inventory without creating an instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Sends a check request without creating the instance. The system checks for required parameters, request format, business limits, and NAS inventory. If the check fails, an error is returned. If the check passes, an HTTP 200 status code is returned, but <c>TaskId</c> is empty.</para>
        /// </description></item>
        /// <item><description><para>false (default): Sends a normal request and creates the instance after the check passes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The destination directory for the data flow task mapping.
        /// Limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The directory must start and end with a forward slash (<c>/</c>). The <c>/../</c> sequence is not supported.</para>
        /// </description></item>
        /// <item><description><para>The length must be 1 to 1,023 characters.</para>
        /// </description></item>
        /// <item><description><para>The directory must be UTF-8 encoded.</para>
        /// </description></item>
        /// <item><description><para>Only one directory can be specified at a time.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Export</c>, this directory must be a relative path within <c>SourceStoragePath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Import</c>, this directory must be a relative path within <c>FileSystemPath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>StreamExport</c>, this directory must be a relative path within <c>SourceStoragePath</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>StreamImport</c>, this directory must be a relative path within <c>FileSystemPath</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><c>StreamImport</c> and <c>StreamExport</c> are supported only by CPFS AI-Computing Edition V2.6.0 and later.</para>
        /// </remarks>
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
        /// <item><description><para>The list must be UTF-8 encoded.</para>
        /// </description></item>
        /// <item><description><para>The total length of the file list must be less than 64 KB.</para>
        /// </description></item>
        /// <item><description><para>The file list must be in JSON format.</para>
        /// </description></item>
        /// <item><description><para>The path of a single file must be 1 to 1,023 characters in length and must start with a forward slash (<c>/</c>).</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Import</c>, each element in the list represents an OSS Object name.</para>
        /// </description></item>
        /// <item><description><para>If <c>TaskAction</c> is <c>Export</c>, each element in the list represents a CPFS file path.</para>
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
        /// <item><description><para>CPFS General Purpose Edition: The ID must start with <c>cpfs-</c>, such as <c>cpfs-125487****</c>.</para>
        /// </description></item>
        /// <item><description><para>CPFS AI-Computing Edition: The ID must start with <c>bmcpfs-</c>, such as <c>bmcpfs-0015****</c>.</para>
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
        /// <para>Filters the subdirectories under the <c>Directory</c> parameter and transfers the content of the filtered subdirectories.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when the <c>Directory</c> parameter is specified.</para>
        /// </description></item>
        /// <item><description><para>The path of a single folder must be 1 to 1,023 characters in length and must start and end with a forward slash (<c>/</c>). The total length cannot exceed 3,000 characters.</para>
        /// </description></item>
        /// <item><description><para>This feature is supported only by CPFS AI-Computing Edition.</para>
        /// </description></item>
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
        /// <para>If you specify <c>SrcTaskId</c>, enter the ID of a data flow task. The system copies the <c>TaskAction</c>, <c>DataType</c>, and <c>EntryList</c> parameter information from the specified task. You do not need to specify these parameters.</para>
        /// <remarks>
        /// <para>Data flow streaming tasks are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>task-29ee8e890f45****</para>
        /// </summary>
        [NameInMap("SrcTaskId")]
        [Validation(Required=false)]
        public string SrcTaskId { get; set; }

        /// <summary>
        /// <para>The type of the data flow task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Import: Imports specified data from the source storage to the CPFS file system.</para>
        /// </description></item>
        /// <item><description><para>Export: Exports specified data from the CPFS file system to the source storage.</para>
        /// </description></item>
        /// <item><description><para>StreamImport: Imports a large amount of specified data from the source storage to the CPFS file system.</para>
        /// </description></item>
        /// <item><description><para>StreamExport: Exports a large amount of specified data from the CPFS file system to the source storage.</para>
        /// </description></item>
        /// <item><description><para>Evict: Releases the data blocks of a file from the CPFS file system. After the release, only the metadata of the file is retained. You can still query the file, but its data blocks are cleared and no longer occupy storage capacity. When you access the file data, it is loaded from the source storage on demand.</para>
        /// </description></item>
        /// <item><description><para>Inventory: Obtains the inventory of files managed by a data flow for the CPFS file system. This provides the cache status of files in the data flow.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>CPFS AI-Computing Edition supports only <c>Import</c>, <c>Export</c>, <c>StreamImport</c>, and <c>StreamExport</c>. <c>StreamImport</c> and <c>StreamExport</c> are supported only by CPFS AI-Computing Edition V2.6.0 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Import</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>Specifies an OSS directory. Data is synchronized based on the content of the CSV files in this directory. The following limits apply.</para>
        /// <list type="bullet">
        /// <item><description><para>The path must start and end with a forward slash (<c>/</c>).</para>
        /// </description></item>
        /// <item><description><para>The path is case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>The length must be between 1 and 1,023 characters.</para>
        /// </description></item>
        /// <item><description><para>The path must be UTF-8 encoded.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><c>TransferFileListPath</c>, <c>Directory</c>, and <c>EntryList</c> are mutually exclusive. You can specify only one of them.</para>
        /// </description></item>
        /// <item><description><para>This parameter specifies an existing path in OSS. The <c>*.csv</c> files are stored in this path.</para>
        /// </description></item>
        /// <item><description><para><c>TransferFileListPath</c> supports only the <c>Import</c> and <c>Export</c> features.</para>
        /// </description></item>
        /// <item><description><para>For an <c>Import</c> task, the files or directories specified in the CSV file are imported from OSS to the CPFS file system.</para>
        /// </description></item>
        /// <item><description><para>For an <c>Export</c> task, the files or directories specified in the CSV file are exported from the CPFS file system to OSS.</para>
        /// </description></item>
        /// <item><description><para>The CSV file must contain <c>Name</c> and <c>Type</c> columns. <c>Name</c> is the relative path. <c>Type</c> can be <c>dir</c> or <c>file</c>. If <c>Type</c> is <c>dir</c>, the <c>Name</c> value must end with a forward slash (<c>/</c>).</para>
        /// </description></item>
        /// <item><description><para>This feature is supported only by CPFS AI-Computing Edition.</para>
        /// </description></item>
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
