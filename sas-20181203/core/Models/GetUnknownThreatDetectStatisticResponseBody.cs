// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetUnknownThreatDetectStatisticResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUnknownThreatDetectStatisticResponseBodyData Data { get; set; }
        public class GetUnknownThreatDetectStatisticResponseBodyData : TeaModel {
            [NameInMap("BlockEventMachineCount")]
            [Validation(Required=false)]
            public int? BlockEventMachineCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlockMachineCount")]
            [Validation(Required=false)]
            public int? BlockMachineCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorMachineCount")]
            [Validation(Required=false)]
            public int? MonitorMachineCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OpenMachineCount")]
            [Validation(Required=false)]
            public int? OpenMachineCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StudyingMachineCount")]
            [Validation(Required=false)]
            public int? StudyingMachineCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD394AF6-591E-5168-8C8C-4C7847******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
