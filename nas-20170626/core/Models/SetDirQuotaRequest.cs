// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetDirQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The number of files that a user can create in the directory.</para>
        /// <para>This number includes the number of files, subdirectories, and special files.</para>
        /// <para>If you set the QuotaType parameter to Enforcement, you must specify at least one of the SizeLimit and FileCountLimit parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileCountLimit")]
        [Validation(Required=false)]
        public long? FileCountLimit { get; set; }

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
        /// <para>The absolute path of the directory in the file system.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can set quotas only for the directories that have been created in a NAS file system. The path of the directory that you specify for a quota is the absolute path of the directory in the NAS file system, but not the local path of the compute node, such as an Elastic Compute Service (ECS) instance or a container.</description></item>
        /// <item><description>Directories whose names contain Chinese characters are not supported.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/sub1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The type of the quota.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Accounting: a statistical quota. If you set this parameter to Accounting, NAS calculates only the storage usage of the directory.</description></item>
        /// <item><description>Enforcement: a restricted quota. If you set this parameter to Enforcement and the storage usage exceeds the quota, you can no longer create files or subdirectories for the directory, or write data to the directory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Accounting</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// <para>The size of files that a user can create in the directory.</para>
        /// <para>Unit: GiB.</para>
        /// <para>If you set the QuotaType parameter to Enforcement, you must specify at least one of the SizeLimit and FileCountLimit parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SizeLimit")]
        [Validation(Required=false)]
        public long? SizeLimit { get; set; }

        /// <summary>
        /// <para>The UID or GID of the user for whom you want to set a directory quota.</para>
        /// <para>This parameter is required and valid only if the UserType parameter is set to Uid or Gid.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>If you want to set a directory quota for a user whose UID is 500, set the UserType parameter to Uid and set the UserId parameter to 500.</description></item>
        /// <item><description>If you want to set a directory quota for a user group whose GID is 100, set the UserType parameter to Gid and set the UserId parameter to 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The type of the user.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uid: user ID</description></item>
        /// <item><description>Gid: user group ID</description></item>
        /// <item><description>AllUsers: all users</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Uid</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
