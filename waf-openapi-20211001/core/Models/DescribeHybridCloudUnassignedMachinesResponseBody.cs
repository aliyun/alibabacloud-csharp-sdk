// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUnassignedMachinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3EBCFCE9-4A3C-5E01-915D-691B****510A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The servers that are not assigned to the hybrid cloud cluster.</para>
        /// </summary>
        [NameInMap("UnassignedMachines")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudUnassignedMachinesResponseBodyUnassignedMachines> UnassignedMachines { get; set; }
        public class DescribeHybridCloudUnassignedMachinesResponseBodyUnassignedMachines : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleName</para>
            /// </summary>
            [NameInMap("CustomName")]
            [Validation(Required=false)]
            public string CustomName { get; set; }

            /// <summary>
            /// <para>The host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online-xagent1</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.X.X.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The media access control (MAC) address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00163e2686ac</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: KB. A conversion factor of 1,000 is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31580872</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78db009ab6cf055a9085f9f4****ae3a</para>
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

        }

    }

}
