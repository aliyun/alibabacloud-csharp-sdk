// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event-triggered alert rule.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public List<PutEventRuleRequestEventPattern> EventPattern { get; set; }
        public class PutEventRuleRequestEventPattern : TeaModel {
            /// <summary>
            /// <para>The keyword that is used to filter events. If the content of an event contains the specified keyword, an alert is automatically triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stopping</para>
            /// </summary>
            [NameInMap("CustomFilters")]
            [Validation(Required=false)]
            public string CustomFilters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Exception</para>
            /// </summary>
            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public List<string> EventTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<string> LevelList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Agent_Status_Stopped</para>
            /// </summary>
            [NameInMap("NameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            /// <summary>
            /// <para>The type of the cloud service. Valid values of N: 1 to 50.</para>
            /// <remarks>
            /// <para> You can call the DescribeSystemEventMetaList operation to query the cloud services that support event-triggered alerts. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
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
            /// <para>The SQL condition that is used to filter events. If the content of an event meets the specified SQL condition, an alert is automatically triggered.</para>
            /// <remarks>
            /// <para> The syntax of SQL event filtering is consistent with the query syntax of Log Service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX and Executed</para>
            /// </summary>
            [NameInMap("SQLFilter")]
            [Validation(Required=false)]
            public string SQLFilter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        /// <summary>
        /// <para>The type of the event-triggered alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYSTEM: system event-triggered alert rule</description></item>
        /// <item><description>CUSTOM: custom event-triggered alert rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The ID of the application group to which the event-triggered alert rule belongs.</para>
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
        /// <para>The name of the event-triggered alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRuleName</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>The status of the event-triggered alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: enabled</description></item>
        /// <item><description>DISABLED: disabled</description></item>
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
