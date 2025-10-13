// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20221014.Models
{
    public class GetCoordinationTicketResponseBody : TeaModel {
        [NameInMap("CoordinateTicketModel")]
        [Validation(Required=false)]
        public GetCoordinationTicketResponseBodyCoordinateTicketModel CoordinateTicketModel { get; set; }
        public class GetCoordinationTicketResponseBodyCoordinateTicketModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>co-dk5xrhqlizm42****</para>
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>W0Rlc2t0b3BdDQpHV1Rva2VuPTAwT1A1bHp1RUlEdU00T0IzemdiZ****</para>
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eab51156-7832-4922-9623-ff905****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

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
