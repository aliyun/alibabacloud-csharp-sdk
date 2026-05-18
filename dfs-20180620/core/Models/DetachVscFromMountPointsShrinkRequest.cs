// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DetachVscFromMountPointsShrinkRequest : TeaModel {
        [NameInMap("DetachInfos")]
        [Validation(Required=false)]
        public string DetachInfosShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("UseAssumeRoleChkServerPerm")]
        [Validation(Required=false)]
        public bool? UseAssumeRoleChkServerPerm { get; set; }

    }

}
