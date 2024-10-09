// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class BindGuestRfidPopRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4546</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public long? ActivityId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z10</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-25 14:11</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-25 14:11</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>451246</para>
        /// </summary>
        [NameInMap("GuestTicketRecordId")]
        [Validation(Required=false)]
        public long? GuestTicketRecordId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdojzopf</para>
        /// </summary>
        [NameInMap("Rfid")]
        [Validation(Required=false)]
        public string Rfid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4546-100000</para>
        /// </summary>
        [NameInMap("TicketCode")]
        [Validation(Required=false)]
        public string TicketCode { get; set; }

    }

}
