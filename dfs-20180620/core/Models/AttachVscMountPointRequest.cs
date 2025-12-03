// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class AttachVscMountPointRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>037****e1d</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

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
        /// <para>[&quot;ecs-instance1&quot;, &quot;ecs-instance2&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>037cb49e1d-c***5</para>
        /// </summary>
        [NameInMap("MountPointId")]
        [Validation(Required=false)]
        public string MountPointId { get; set; }

        [NameInMap("UseAssumeRoleChkServerPerm")]
        [Validation(Required=false)]
        public bool? UseAssumeRoleChkServerPerm { get; set; }

        [NameInMap("VscIds")]
        [Validation(Required=false)]
        public List<string> VscIds { get; set; }

        [NameInMap("VscName")]
        [Validation(Required=false)]
        public string VscName { get; set; }

        [NameInMap("VscType")]
        [Validation(Required=false)]
        public string VscType { get; set; }

    }

}
