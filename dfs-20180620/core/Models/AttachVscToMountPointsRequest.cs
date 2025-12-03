// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class AttachVscToMountPointsRequest : TeaModel {
        [NameInMap("AttachInfos")]
        [Validation(Required=false)]
        public List<AttachVscToMountPointsRequestAttachInfos> AttachInfos { get; set; }
        public class AttachVscToMountPointsRequestAttachInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-2zehyz70ednszl6rrfj6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f-cfea9ae2ref87.cn-zhangjiakou.dfs.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsc-bp19yqmujug2r762cnabal</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xc</para>
            /// </summary>
            [NameInMap("VscName")]
            [Validation(Required=false)]
            public string VscName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("VscType")]
            [Validation(Required=false)]
            public string VscType { get; set; }

        }

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
