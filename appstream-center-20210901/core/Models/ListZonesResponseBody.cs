// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The zone query result.</para>
        /// </summary>
        [NameInMap("ListZonesModel")]
        [Validation(Required=false)]
        public ListZonesResponseBodyListZonesModel ListZonesModel { get; set; }
        public class ListZonesResponseBodyListZonesModel : TeaModel {
            /// <summary>
            /// <para>The list of available zone IDs for the specified product type and operating system type in the current region. When creating a resource that requires a vSwitch, select a vSwitch in one of these zones.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
