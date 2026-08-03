// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifySmbAclRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow anonymous access. </para>
        /// <list type="bullet">
        /// <item><description><para>true: Anonymous access is allowed.</para>
        /// </description></item>
        /// <item><description><para>false (default): Anonymous access is not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EnableAnonymousAccess")]
        [Validation(Required=false)]
        public bool? EnableAnonymousAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable encryption in transit.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Encryption in transit is enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): Encryption in transit is not enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptData")]
        [Validation(Required=false)]
        public bool? EncryptData { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The home folder path for each user. The file path format is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Use a forward slash (/) or backslash (\) as the separator.</para>
        /// </description></item>
        /// <item><description><para>Each segment cannot contain <c>&lt;&gt;&quot;:|?*</c>.</para>
        /// </description></item>
        /// <item><description><para>The length of each segment ranges from 0 to 255.</para>
        /// </description></item>
        /// <item><description><para>The total length ranges from 0 to 32767.</para>
        /// </description></item>
        /// </list>
        /// <para>For example, if the user folder is <c>/home</c>, the file system performs automatic creation of the <c>/home/A</c> folder when user A performs logon. If <c>/home/A</c> already exists, this step is skipped.</para>
        /// <remarks>
        /// <para>User A must have the permission to create folders. Otherwise, the <c>/home/A</c> folder cannot be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("HomeDirPath")]
        [Validation(Required=false)]
        public string HomeDirPath { get; set; }

        /// <summary>
        /// <para>The Base64-encoded string of the keytab file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BQIAAABHAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAAQAIqIx6v7p11oUAAABHAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAAwAIqIx6v7p11oUAAABPAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAFwAQnQZWB3RAPHU7PMIJyBWePAAAAF8AAgANQUxJQURURVNULkNPTQAEY2lmcwAZc21ic2VydmVyMjQuYWxpYWR0ZXN0LmNvbQAAAAEAAAAAAQASACAGJ7F0s+bcBjf6jD5HlvlRLmPSOW+qDZe0Qk0lQcf8WwAAAE8AAgANQUxJQURURVNULkNPTQAEY2lmcwAZc21ic2VydmVyMjQuYWxpYWR0ZXN0LmNvbQAAAAEAAAAAAQARABDdFmanrSIatnDDh****</para>
        /// </summary>
        [NameInMap("Keytab")]
        [Validation(Required=false)]
        public string Keytab { get; set; }

        /// <summary>
        /// <para>The MD5-encrypted string of the keytab file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3CCF7E2416DF04FA958AA4513EA****</para>
        /// </summary>
        [NameInMap("KeytabMd5")]
        [Validation(Required=false)]
        public string KeytabMd5 { get; set; }

        /// <summary>
        /// <para>Specifies whether to reject unencrypted clients.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Unencrypted clients are rejected.</para>
        /// </description></item>
        /// <item><description><para>false (default): Unencrypted clients are not rejected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RejectUnencryptedAccess")]
        [Validation(Required=false)]
        public bool? RejectUnencryptedAccess { get; set; }

        /// <summary>
        /// <para>The ID of the superuser. The ID must follow these rules:</para>
        /// <list type="bullet">
        /// <item><description><para>Must start with <c>S</c>, and no other letters are allowed after the initial S.</para>
        /// </description></item>
        /// <item><description><para>Must contain at least three hyphens (-) as separators.</para>
        /// </description></item>
        /// </list>
        /// <para>For example, <c>S-1-5-22</c> or <c>S-1-5-22-23</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S-1-5-22</para>
        /// </summary>
        [NameInMap("SuperAdminSid")]
        [Validation(Required=false)]
        public string SuperAdminSid { get; set; }

    }

}
