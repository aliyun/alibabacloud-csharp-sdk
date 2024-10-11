// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsAttachedEcsInstancesResponseBody : TeaModel {
        [NameInMap("EcsLabelInfo")]
        [Validation(Required=false)]
        public List<ListDbfsAttachedEcsInstancesResponseBodyEcsLabelInfo> EcsLabelInfo { get; set; }
        public class ListDbfsAttachedEcsInstancesResponseBodyEcsLabelInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.g7se</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mnt/dbfs/dbfs-nUy1tb********BQ4X8Gpw</para>
            /// </summary>
            [NameInMap("MountPoint")]
            [Validation(Required=false)]
            public string MountPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1606290930000</para>
            /// </summary>
            [NameInMap("MountedTime")]
            [Validation(Required=false)]
            public string MountedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux 2.1903 LTS 64 bit</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-test-01</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-bp10jb8mqajkmrejgo00</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
