// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the Event-triggered Alert Rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Event alert test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The pattern of the Event-triggered Alert Rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public List<PutEventRuleRequestEventPattern> EventPattern { get; set; }
        public class PutEventRuleRequestEventPattern : TeaModel {
            /// <summary>
            /// <para>The keyword for event filtering. When the event content contains this keyword, an alert is automatically triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stopping</para>
            /// </summary>
            [NameInMap("CustomFilters")]
            [Validation(Required=false)]
            public string CustomFilters { get; set; }

            /// <summary>
            /// <para>The type of the Event-triggered Alert Rule. Valid values of N: 1 to 50. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>StatusNotification: fault notification.</para>
            /// </description></item>
            /// <item><description><para>Exception: exception.</para>
            /// </description></item>
            /// <item><description><para>Maintenance: O&amp;M.</para>
            /// </description></item>
            /// <item><description><para>\*: unlimited.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Exception</para>
            /// </summary>
            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public List<string> EventTypeList { get; set; }

            /// <summary>
            /// <para>The level of the Event-triggered Alert Rule. Valid values of N: 1 to 50. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CRITICAL: critical.</para>
            /// </description></item>
            /// <item><description><para>WARN: warning.</para>
            /// </description></item>
            /// <item><description><para>INFO: information.</para>
            /// </description></item>
            /// <item><description><para>\*: all levels.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<string> LevelList { get; set; }

            /// <summary>
            /// <para>The name of the Event-triggered Alert Rule. Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent_Status_Stopped</para>
            /// </summary>
            [NameInMap("NameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud service type. Valid values of N: 1 to 50.</para>
            /// <remarks>
            /// <para>For information about the Alibaba Cloud services supported by Event-triggered Alert Rules, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The SQL filter for events. When the event content meets the SQL condition, an alert is automatically triggered.</para>
            /// <remarks>
            /// <para>The syntax of the SQL event filter is consistent with the query syntax of Simple Log Service (SLS).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX and Executed</para>
            /// </summary>
            [NameInMap("SQLFilter")]
            [Validation(Required=false)]
            public string SQLFilter { get; set; }

            /// <summary>
            /// <para>The status of the Event-triggered Alert Rule. Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        /// <summary>
        /// <para>The type of the Event-triggered Alert Rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYSTEM: system event.</description></item>
        /// <item><description>CUSTOM: custom event.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the application group to which the Event-triggered Alert Rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7378****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the Event-triggered Alert Rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRuleName</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The mute period. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>The status of the Event-triggered Alert Rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: enabled.</description></item>
        /// <item><description>DISABLED: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
