// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3D924FB-52****B253-0C1A7EFB778C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeInstanceAvailableZonesResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeInstanceAvailableZonesResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsInCluster")]
            [Validation(Required=false)]
            public bool? IsInCluster { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-g-z0,cn-shanghai-g-z1, cn-shanghai-g-z2</para>
            /// </summary>
            [NameInMap("LogicalZoneName")]
            [Validation(Required=false)]
            public string LogicalZoneName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReplicateZoneIndex")]
            [Validation(Required=false)]
            public string ReplicateZoneIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
