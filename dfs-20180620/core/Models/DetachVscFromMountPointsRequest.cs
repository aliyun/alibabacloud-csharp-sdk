// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DetachVscFromMountPointsRequest : TeaModel {
        [NameInMap("DetachInfos")]
        [Validation(Required=false)]
        public List<DetachVscFromMountPointsRequestDetachInfos> DetachInfos { get; set; }
        public class DetachVscFromMountPointsRequestDetachInfos : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            [NameInMap("VscName")]
            [Validation(Required=false)]
            public string VscName { get; set; }

            [NameInMap("VscType")]
            [Validation(Required=false)]
            public string VscType { get; set; }

        }

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
