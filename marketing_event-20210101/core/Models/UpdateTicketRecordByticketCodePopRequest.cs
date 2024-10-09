// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class UpdateTicketRecordByticketCodePopRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3402</para>
        /// </summary>
        [NameInMap("AgendaId")]
        [Validation(Required=false)]
        public string AgendaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4546-100000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>boarding</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-25 14:11</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
