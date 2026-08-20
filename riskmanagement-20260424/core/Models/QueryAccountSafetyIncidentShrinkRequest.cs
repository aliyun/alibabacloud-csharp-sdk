// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryAccountSafetyIncidentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of control action codes.</para>
        /// </summary>
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public string ActionCodesShrink { get; set; }

        /// <summary>
        /// <para>The internationalization language. Default value: zh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The event name code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RISKCONTROL_IMS_IMS_BAN_SUBUSER</para>
        /// </summary>
        [NameInMap("CaseCode")]
        [Validation(Required=false)]
        public string CaseCode { get; set; }

        /// <summary>
        /// <para>The list of event name codes.</para>
        /// </summary>
        [NameInMap("CaseCodes")]
        [Validation(Required=false)]
        public string CaseCodesShrink { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2PTOHhN3YUeaPWzq9FLmpdZ9EOW</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("EventIds")]
        [Validation(Required=false)]
        public string EventIdsShrink { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The control end time.</para>
        /// <remarks>
        /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-16 15:15:00</para>
        /// </summary>
        [NameInMap("PunishEndTime")]
        [Validation(Required=false)]
        public string PunishEndTime { get; set; }

        /// <summary>
        /// <para>The control start time.</para>
        /// <remarks>
        /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-16 15:15:00</para>
        /// </summary>
        [NameInMap("PunishStartTime")]
        [Validation(Required=false)]
        public string PunishStartTime { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RES001</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: In progress.</description></item>
        /// <item><description><b>Removed</b>: Removed.</description></item>
        /// <item><description><b>Alerting</b>: Alerting.</description></item>
        /// <item><description><b>Ended</b>: Ended.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}
