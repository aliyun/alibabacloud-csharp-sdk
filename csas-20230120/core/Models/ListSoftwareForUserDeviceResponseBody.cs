// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListSoftwareForUserDeviceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Software")]
        [Validation(Required=false)]
        public List<ListSoftwareForUserDeviceResponseBodySoftware> Software { get; set; }
        public class ListSoftwareForUserDeviceResponseBodySoftware : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Alibaba (China) Network Technology Co.,Ltd.</para>
            /// </summary>
            [NameInMap("Inc")]
            [Validation(Required=false)]
            public string Inc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-18 02:43:02</para>
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public string InstallTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
