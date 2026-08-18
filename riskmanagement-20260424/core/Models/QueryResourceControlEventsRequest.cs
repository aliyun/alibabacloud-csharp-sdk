// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryResourceControlEventsRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>shutdown</para>
        /// </summary>
        [NameInMap("ActionCodes")]
        [Validation(Required=false)]
        public List<string> ActionCodes { get; set; }

        /// <summary>
        /// <para>The internationalization language.</para>
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
        /// <para>The list of product types.</para>
        /// </summary>
        [NameInMap("BusinessCodes")]
        [Validation(Required=false)]
        public List<string> BusinessCodes { get; set; }

        /// <summary>
        /// <para>The collection of event name code prefixes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;BANFF\&quot;]</para>
        /// </summary>
        [NameInMap("CaseCodesPrefix")]
        [Validation(Required=false)]
        public List<string> CaseCodesPrefix { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;BANFF_ECS_PE_ECS_MINING_SHUTDOWN&quot;]</para>
        /// </summary>
        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public List<string> EventCodes { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2PTOHhN3YUeaPWzq9FLmpdZ9EOW</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The collection of event IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;7ac74fbfe06b2b85bb470083b7a05fb7\&quot;,\&quot;1180c5bbff0a385b00d2cf73e3371d11\&quot;]</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<string> EventIdList { get; set; }

        /// <summary>
        /// <para>The collection of excluded control action name codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;shutdown\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeActionCodes")]
        [Validation(Required=false)]
        public List<string> ExcludeActionCodes { get; set; }

        /// <summary>
        /// <para>The collection of excluded event name codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;TEST_CASE\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeEventCodes")]
        [Validation(Required=false)]
        public List<string> ExcludeEventCodes { get; set; }

        /// <summary>
        /// <para>The collection of excluded event reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;Cryptomining alert\&quot;,\&quot;Cryptomining control event\&quot;,\&quot;Cryptomining\&quot;]</para>
        /// </summary>
        [NameInMap("ExcludeReasons")]
        [Validation(Required=false)]
        public List<string> ExcludeReasons { get; set; }

        /// <summary>
        /// <para>The collection of included event reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;Cryptomining alert\&quot;,\&quot;Cryptomining control event\&quot;,\&quot;Cryptomining\&quot;]</para>
        /// </summary>
        [NameInMap("IncludeReasons")]
        [Validation(Required=false)]
        public List<string> IncludeReasons { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-16 15:15:00</para>
        /// </summary>
        [NameInMap("PunishEndTime")]
        [Validation(Required=false)]
        public string PunishEndTime { get; set; }

        /// <summary>
        /// <para>The penalty start time.</para>
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
        /// <para>Cryptomining</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The collection of event source codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;MRM\&quot;]</para>
        /// </summary>
        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public List<string> SourceCodes { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of task statuses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: executing</description></item>
        /// <item><description><b>Removed</b>: removed</description></item>
        /// <item><description><b>Alerting</b>: alerting</description></item>
        /// <item><description><b>Ended</b>: ended</description></item>
        /// <item><description><b>Processed</b>: processed by the user and under platform review</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;Executing\&quot;]</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

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
