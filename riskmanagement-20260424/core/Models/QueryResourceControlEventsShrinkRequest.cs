// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryResourceControlEventsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>shutdown</para>
        /// </summary>
        [NameInMap("ActionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>shutdown</para>
        /// </summary>
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public string ActionCodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("BusinessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;BANFF\&quot;]</para>
        /// </summary>
        [NameInMap("CaseCodesPrefix")]
        [Validation(Required=false)]
        public string CaseCodesPrefixShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>short.industry.taobao.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BANFF_ECS_PE_ECS_MINING_SHUTDOWN</para>
        /// </summary>
        [NameInMap("EventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;BANFF_ECS_PE_ECS_MINING_SHUTDOWN&quot;]</para>
        /// </summary>
        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public string EventCodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2PTOHhN3YUeaPWzq9FLmpdZ9EOW</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;7ac74fbfe06b2b85bb470083b7a05fb7\&quot;,\&quot;1180c5bbff0a385b00d2cf73e3371d11\&quot;]</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public string EventIdListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;shutdown\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeActionCodes")]
        [Validation(Required=false)]
        public string ExcludeActionCodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;TEST_CASE\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeEventCodes")]
        [Validation(Required=false)]
        public string ExcludeEventCodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;挖矿告警\&quot;,\&quot;挖矿管控事件\&quot;,\&quot;挖矿\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeReasons")]
        [Validation(Required=false)]
        public string ExcludeReasonsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;挖矿告警\&quot;,\&quot;挖矿管控事件\&quot;,\&quot;挖矿\&quot;]</para>
        /// </summary>
        [NameInMap("IncludeReasons")]
        [Validation(Required=false)]
        public string IncludeReasonsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-0iw73ro05vcwn6ntq</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12.3*.22.11</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>挖矿</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;MRM\&quot;]</para>
        /// </summary>
        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public string SourceCodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;Executing\&quot;]</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://qimg.xiaohongshu.com/circe/1040g1v831qggp28ln0705oft1i6k1jil889lhso?imageView2/2/w/1080/format/jpg">https://qimg.xiaohongshu.com/circe/1040g1v831qggp28ln0705oft1i6k1jil889lhso?imageView2/2/w/1080/format/jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
