// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class AttachVscToMountPointsShrinkRequest : TeaModel {
        [NameInMap("AttachInfos")]
        [Validation(Required=false)]
        public string AttachInfosShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseAssumeRoleChkServerPerm")]
        [Validation(Required=false)]
        public bool? UseAssumeRoleChkServerPerm { get; set; }

    }

}
