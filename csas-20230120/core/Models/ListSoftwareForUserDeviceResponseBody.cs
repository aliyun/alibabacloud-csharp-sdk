// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListSoftwareForUserDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of software applications.</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public List<ListSoftwareForUserDeviceResponseBodySoftware> Software { get; set; }
        public class ListSoftwareForUserDeviceResponseBodySoftware : TeaModel {
            /// <summary>
            /// <para>The publisher of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba (China) Network Technology Co.,Ltd.</para>
            /// </summary>
            [NameInMap("Inc")]
            [Validation(Required=false)]
            public string Inc { get; set; }

            /// <summary>
            /// <para>The time when the software was installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-18 02:43:02</para>
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public string InstallTime { get; set; }

            /// <summary>
            /// <para>The name of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>钉钉</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The versions of the software.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// <para>The total number of software applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
