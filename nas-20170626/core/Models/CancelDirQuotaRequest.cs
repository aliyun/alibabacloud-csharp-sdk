// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelDirQuotaRequest : TeaModel {
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
        /// <para>The absolute path of the directory in the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/sub1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The UID or GID to cancel.</para>
        /// <para>This parameter is required and valid only when UserType is set to Uid or Gid.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>To cancel the quota for the user whose UID is 500, set UserType to Uid and UserId to 500.</description></item>
        /// <item><description>To cancel the quota for the user group whose GID is 100, set UserType to Gid and UserId to 100.</description></item>
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
        /// <item><description>Gid: user group ID</description></item>
        /// <item><description>AllUsers: all users.</description></item>
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
