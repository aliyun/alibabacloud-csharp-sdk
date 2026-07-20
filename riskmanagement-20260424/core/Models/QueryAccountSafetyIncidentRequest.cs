// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryAccountSafetyIncidentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RISKCONTROL_IMS_IMS_BAN_SUBUSER</para>
        /// </summary>
        [NameInMap("CaseCode")]
        [Validation(Required=false)]
        public string CaseCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2PTOHhN3YUeaPWzq9FLmpdZ9EOW</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-16 15:15:00</para>
        /// </summary>
        [NameInMap("PunishEndTime")]
        [Validation(Required=false)]
        public string PunishEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-03-16 15:15:00</para>
        /// </summary>
        [NameInMap("PunishStartTime")]
        [Validation(Required=false)]
        public string PunishStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RES001</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
