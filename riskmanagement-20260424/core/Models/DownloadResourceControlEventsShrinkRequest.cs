// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DownloadResourceControlEventsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The action name code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shutdown</para>
        /// </summary>
        [NameInMap("ActionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// <para>The collection of control action name codes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;shutdown\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public string ActionCodesShrink { get; set; }

        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default).</description></item>
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
        /// <para>The product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("BusinessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        /// <summary>
        /// <para>The collection of event name code prefixes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;BANFF\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CaseCodesPrefix")]
        [Validation(Required=false)]
        public string CaseCodesPrefixShrink { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <remarks>
        /// <para>Must be greater than 0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>short.industry.taobao.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The event name code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BANFF_ECS_PE_ECS_MINING_SHUTDOWN</para>
        /// </summary>
        [NameInMap("EventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>The collection of event name codes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;BANFF_ECS_PE_ECS_MINING_SHUTDOWN\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public string EventCodesShrink { get; set; }

        /// <summary>
        /// <para>The alert event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09C-2PpwIzkpx2zG2fuFrAH55CpJaTK</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The collection of excluded control action name codes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;shutdown\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ExcludeActionCodes")]
        [Validation(Required=false)]
        public string ExcludeActionCodesShrink { get; set; }

        /// <summary>
        /// <para>The collection of excluded event name codes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;TEST_CASE\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ExcludeEventCodes")]
        [Validation(Required=false)]
        public string ExcludeEventCodesShrink { get; set; }

        /// <summary>
        /// <para>The collection of excluded event reasons.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;Mining alert\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ExcludeReasons")]
        [Validation(Required=false)]
        public string ExcludeReasonsShrink { get; set; }

        /// <summary>
        /// <para>The collection of included event reasons.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;Mining alert\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IncludeReasons")]
        [Validation(Required=false)]
        public string IncludeReasonsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-0iw73ro05vcwn6ntq</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>IP</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.3*.22.11</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The penalty end time.</para>
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
        /// <para>The penalty start time.</para>
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
        /// <para>The event reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mining</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The collection of event source codes.</para>
        /// <remarks>
        /// <para>Example: [\\\&quot;MRM\\\&quot;]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public string SourceCodesShrink { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: In progress.</description></item>
        /// <item><description><b>Removed</b>: Removed.</description></item>
        /// <item><description><b>Alerting</b>: Alerting.</description></item>
        /// <item><description><b>Ended</b>: Ended.</description></item>
        /// <item><description><b>Processed</b>: Processed by the user and pending platform review.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of task statuses.</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: In progress.</description></item>
        /// <item><description><b>Removed</b>: Removed.</description></item>
        /// <item><description><b>Alerting</b>: Alerting.</description></item>
        /// <item><description><b>Ended</b>: Ended.</description></item>
        /// <item><description><b>Processed</b>: Processed by the user and pending platform review.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        /// <summary>
        /// <para>The control URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://qimg.xiaohongshu.com/circe/1040g1v831qggp28ln0705oft1i6k1jil889lhso?imageView2/2/w/1080/format/jpg">https://qimg.xiaohongshu.com/circe/1040g1v831qggp28ln0705oft1i6k1jil889lhso?imageView2/2/w/1080/format/jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
