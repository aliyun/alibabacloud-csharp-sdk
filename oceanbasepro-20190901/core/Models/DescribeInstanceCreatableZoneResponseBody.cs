// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceCreatableZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the cluster is deployed in the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeInstanceCreatableZone</b>.</para>
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeInstanceCreatableZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeInstanceCreatableZoneResponseBodyZoneList : TeaModel {
            [NameInMap("FullCopyId")]
            [Validation(Required=false)]
            public string FullCopyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsInCluster")]
            [Validation(Required=false)]
            public bool? IsInCluster { get; set; }

            [NameInMap("LogicalZoneName")]
            [Validation(Required=false)]
            public string LogicalZoneName { get; set; }

            [NameInMap("ReplicateZoneIndex")]
            [Validation(Required=false)]
            public long? ReplicateZoneIndex { get; set; }

            /// <summary>
            /// <para>DescribeInstanceCreatableZone</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
