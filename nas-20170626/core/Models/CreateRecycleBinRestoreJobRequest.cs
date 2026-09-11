// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateRecycleBinRestoreJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a value from your client to ensure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify ClientToken, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The FileId of the file or directory to restore.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2412174.html">ListRecycledDirectoriesAndFiles</a> operation to query the FileId of deleted data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04***08</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The file system ID. <b>Required</b>.</para>
        /// <para><b>How to obtain</b>:</para>
        /// <list type="bullet">
        /// <item><description>Call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> to query the file system list and obtain the FileSystemId.</description></item>
        /// <item><description>Call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-createfilesystem">CreateFileSystem</a> to create a file system and obtain the FileSystemId from the response.</description></item>
        /// </list>
        /// <para><b>Usage notes</b>:</para>
        /// <list type="bullet">
        /// <item><description>This operation applies only to General-purpose NAS file systems.</description></item>
        /// <item><description>Before calling this operation, make sure that the recycle bin feature is enabled for the file system.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The FileId of the directory to which the file is restored.</para>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/2412173.html">ListRecentlyRecycledDirectories</a> operation to query the TargetFileId of directories from which files have been deleted.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/2412163.html">ListDirectoriesAndFiles</a> operation to query the TargetFileId of existing directories in the file system.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Special notes</b>:</para>
        /// <list type="bullet">
        /// <item><description>The FileId of the root directory of a file system is fixed to <c>2</c>. You can directly use this value as the TargetFileId to restore a file to the root directory without querying.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13***15</para>
        /// </summary>
        [NameInMap("TargetFileId")]
        [Validation(Required=false)]
        public string TargetFileId { get; set; }

    }

}
