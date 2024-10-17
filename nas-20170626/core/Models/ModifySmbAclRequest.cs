// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifySmbAclRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow anonymous access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The file system allows anonymous access.</description></item>
        /// <item><description>false (default): The file system denies anonymous access.</description></item>
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
        /// <para>Specifies whether to enable encryption in transit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables encryption in transit.</description></item>
        /// <item><description>false (default): disables encryption in transit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptData")]
        [Validation(Required=false)]
        public bool? EncryptData { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The home directory of each user. Each user-specific home directory must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Each segment starts with a forward slash (/) or a backward slash (\\).</description></item>
        /// <item><description>Each segment does not contain the following special characters: <c>&lt;&gt;&quot;:|?*</c>.</description></item>
        /// <item><description>Each segment is 0 to 255 characters in length.</description></item>
        /// <item><description>The total length is 0 to 32,767 characters.</description></item>
        /// </list>
        /// <para>For example, if you create a user named A and the home directory is <c>/home</c>, the file system automatically creates a directory named <c>/home/A</c> when User A logs on to the file system. If the <c>/home/A</c> directory already exists, the file system does not create the directory.</para>
        /// <remarks>
        /// <para>User A must have the permissions to create folders in the \home directory. Otherwise, the file system cannot create the <c>/home/A</c> directory when User A logs on to the file system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("HomeDirPath")]
        [Validation(Required=false)]
        public string HomeDirPath { get; set; }

        /// <summary>
        /// <para>The string that is generated after the system encodes the keytab file by using Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BQIAAABHAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAAQAIqIx6v7p11oUAAABHAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAAwAIqIx6v7p11oUAAABPAAIADUFMSUFEVEVTVC5DT00ABGNpZnMAGXNtYnNlcnZlcjI0LmFsaWFkdGVzdC5jb20AAAABAAAAAAEAFwAQnQZWB3RAPHU7PMIJyBWePAAAAF8AAgANQUxJQURURVNULkNPTQAEY2lmcwAZc21ic2VydmVyMjQuYWxpYWR0ZXN0LmNvbQAAAAEAAAAAAQASACAGJ7F0s+bcBjf6jD5HlvlRLmPSOW+qDZe0Qk0lQcf8WwAAAE8AAgANQUxJQURURVNULkNPTQAEY2lmcwAZc21ic2VydmVyMjQuYWxpYWR0ZXN0LmNvbQAAAAEAAAAAAQARABDdFmanrSIatnDDh****</para>
        /// </summary>
        [NameInMap("Keytab")]
        [Validation(Required=false)]
        public string Keytab { get; set; }

        /// <summary>
        /// <para>The string that is generated after the system encodes the keytab file by using MD5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3CCF7E2416DF04FA958AA4513EA****</para>
        /// </summary>
        [NameInMap("KeytabMd5")]
        [Validation(Required=false)]
        public string KeytabMd5 { get; set; }

        /// <summary>
        /// <para>Specifies whether to deny access from non-encrypted clients. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The file system denies access from non-encrypted clients.</description></item>
        /// <item><description>false (default): The file system allows access from non-encrypted clients.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RejectUnencryptedAccess")]
        [Validation(Required=false)]
        public bool? RejectUnencryptedAccess { get; set; }

        /// <summary>
        /// <para>The ID of a super admin. The ID must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ID starts with <c>S</c> and does not contain letters except S.</description></item>
        /// <item><description>The ID contains at least three hyphens (-) as delimiters.</description></item>
        /// </list>
        /// <para>Examples: <c>S-1-5-22</c> and <c>S-1-5-22-23</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S-1-5-22</para>
        /// </summary>
        [NameInMap("SuperAdminSid")]
        [Validation(Required=false)]
        public string SuperAdminSid { get; set; }

    }

}
