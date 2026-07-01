// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PolarFsConfig : TeaModel {
        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// <para>The mount points.</para>
        /// </summary>
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<PolarFsMountConfig> MountPoints { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public int? UserId { get; set; }

    }

}
