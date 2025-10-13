// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20221014.Models
{
    public class ApplyCoordinationForCoordinatorResponseBody : TeaModel {
        [NameInMap("CoordinateFlowModels")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForCoordinatorResponseBodyCoordinateFlowModels> CoordinateFlowModels { get; set; }
        public class ApplyCoordinationForCoordinatorResponseBodyCoordinateFlowModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>co-9kt75fon9pj****</para>
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>W0Rlc2t0b3BdDQpHV1Rva2VuPTAwT1A1bHp1RUlEdU00T0IzemdiZ****</para>
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10419178654***</para>
            /// </summary>
            [NameInMap("CoordinatorUserId")]
            [Validation(Required=false)]
            public string CoordinatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ai-ij4a6kd4bn2****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-resource</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
