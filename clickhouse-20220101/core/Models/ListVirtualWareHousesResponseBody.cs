// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class ListVirtualWareHousesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVirtualWareHousesResponseBodyData> Data { get; set; }
        public class ListVirtualWareHousesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp:9000,http:8123,mysql:9004</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("VirtualWareHouseCacheStorage")]
            [Validation(Required=false)]
            public int? VirtualWareHouseCacheStorage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n1.xlarge</para>
            /// </summary>
            [NameInMap("VirtualWareHouseClass")]
            [Validation(Required=false)]
            public string VirtualWareHouseClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VirtualWareHouseDescription")]
            [Validation(Required=false)]
            public string VirtualWareHouseDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vw-bp1w2728d535t****</para>
            /// </summary>
            [NameInMap("VirtualWareHouseId")]
            [Validation(Required=false)]
            public string VirtualWareHouseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("VirtualWareHouseStatus")]
            [Validation(Required=false)]
            public string VirtualWareHouseStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp1tg609m5j85jejq****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD4F7C49-09BC-5BA7-BAC9-F0887E368126</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
