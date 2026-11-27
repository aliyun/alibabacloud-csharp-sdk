// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetDirQuotaRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a precheck on the request.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The maximum number of files in the directory.</para>
        /// <para>This includes files, directories, and special files.</para>
        /// <para>When QuotaType is set to Enforcement, you must specify at least one of SizeLimit and FileCountLimit.</para>
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
        /// <item><description>Quotas can only be set for directories that have been created in a NAS file system. The quota path is the absolute path of the directory in the NAS file system, not a local path on a compute node (such as an ECS instance or container).</description></item>
        /// <item><description>Directories whose path names contain Chinese characters are not supported.</description></item>
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
        /// <para>The quota type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Accounting: accounting quota, which only tracks usage.</description></item>
        /// <item><description>Enforcement: enforcement quota. If usage exceeds the limit, operations such as creating files or directories and appending data will fail.</description></item>
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
        /// <para>The maximum total size of files in the directory.</para>
        /// <para>Unit: GiB</para>
        /// <para>When QuotaType is set to Enforcement, you must specify at least one of SizeLimit and FileCountLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SizeLimit")]
        [Validation(Required=false)]
        public long? SizeLimit { get; set; }

        /// <summary>
        /// <para>The Uid or Gid to be restricted.</para>
        /// <para>Required and meaningful only when UserType is Uid or Gid.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>To restrict the user with Uid=500, set UserType to Uid and UserId to 500.</description></item>
        /// <item><description>To restrict the user group with Gid=100, set UserType to Gid and UserId to 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uid: user ID</description></item>
        /// <item><description>Gid: group ID of the user</description></item>
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
