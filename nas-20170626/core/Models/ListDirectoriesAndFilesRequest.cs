// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListDirectoriesAndFilesRequest : TeaModel {
        /// <summary>
        /// <para>Whether to list only directories.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>false</c> (default): Lists both directories and files.</para>
        /// </description></item>
        /// <item><description><para><c>true</c>: Lists only directories.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <c>StorageType</c> to <c>All</c>, you must set <c>DirectoryOnly</c> to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DirectoryOnly")]
        [Validation(Required=false)]
        public bool? DirectoryOnly { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The maximum number of directories or files to return per page.</para>
        /// <para>Value range: 10–128</para>
        /// <para>Default value: 100</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>A continuation token used to retrieve the next page of results when the response is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The absolute path of the directory.</para>
        /// <para>The path must start with a forward slash (/) and exist on the mount target.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/pathway/to/folder</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <list type="bullet">
        /// <item><description><para><c>InfrequentAccess</c>: infrequent access.</para>
        /// </description></item>
        /// <item><description><para><c>Archive</c>: archive storage.</para>
        /// </description></item>
        /// <item><description><para><c>All</c>: all storage types.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <c>StorageType</c> to <c>All</c>, you must set <c>DirectoryOnly</c> to <c>true</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
