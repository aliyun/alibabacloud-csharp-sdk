// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class NASConfig : TeaModel {
        /// <summary>
        /// <para>The group ID for file system access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// <para>A list of mount point configurations.</para>
        /// </summary>
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<NASMountConfig> MountPoints { get; set; }

        /// <summary>
        /// <para>The user ID for file system access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public int? UserId { get; set; }

    }

}
