// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class SetEventSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the event subscription feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the event subscription feature.</description></item>
        /// <item><description><b>1</b>: enables the event subscription feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public string Active { get; set; }

        /// <summary>
        /// <para>The notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hdm_alarm_sms</b>: text message.</description></item>
        /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
        /// <item><description><b>hdm_alarm_sms_and_email</b>: text message and email.</description></item>
        /// <item><description><b>hdm_alarm_sms,dingtalk</b>: text message and DingTalk chatbot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hdm_alarm_sms,dingtalk</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The name of the contact group that receives alert notifications. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default contact group</para>
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// <para>The name of the contact who receives alert notifications. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default contact</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The notification rules based on the event type. If you leave this parameter empty, the values of <b>MinInterval</b> and <b>ChannelType</b> prevail.</para>
        /// <para>Specify this parameter in the following format: <c>{&quot;silenced&quot;: {&quot;Event type 1&quot;:Specifies whether to enable adaptive silence, &quot;Event type 2&quot;:Specify whether to enable adaptive silence},&quot;min_interval&quot;: {&quot;Event type 1&quot;:Minimum interval between event notifications, &quot;Event type 2&quot;:Minimum interval between event notifications},&quot;alert_type&quot;: {&quot;Event type 1&quot;:&quot;Notification method&quot;, &quot;Event type 2&quot;:&quot;Notification method&quot;}}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>silenced</b>: specifies whether to enable adaptive silence. After you enable adaptive silence, the interval between consecutive alert notifications for an event is the greater one of the minimum interval specified by <b>min_interval</b> and one third of the event duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: enables adaptive silence.</description></item>
        /// <item><description>2: disables adaptive silence.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>min_interval</b>: the minimum interval between event notifications. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>alert_type</b>: the notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hdm_alarm_sms</b>: text message.</description></item>
        /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
        /// <item><description><b>hdm_alarm_sms_and_email</b>: text message and email.</description></item>
        /// <item><description><b>hdm_alarm_sms,dingtalk</b>: text message and DingTalk chatbot.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;silenced&quot;: {&quot;AutoScale&quot;:1, &quot;SQLThrottle&quot;:0, &quot;TimeSeriesAbnormal&quot;: 1}, &quot;min_interval&quot;: {&quot;AutoScale&quot;:300, &quot;SQLThrottle&quot;:360, &quot;TimeSeriesAbnormal&quot;: 120}, &quot;alert_type&quot;: {&quot;AutoScale&quot;:&quot;hdm_alarm_sms&quot;, &quot;SQLThrottle&quot;:&quot;hdm_alarm_sms_and_email&quot;, &quot;TimeSeriesAbnormal&quot;: &quot;hdm_alarm_sms,dingtalk&quot;}}</para>
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public string DispatchRule { get; set; }

        /// <summary>
        /// <para>The supported event scenarios. You can set the value to <b>AllContext</b>, which indicates that all scenarios are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllContext</para>
        /// </summary>
        [NameInMap("EventContext")]
        [Validation(Required=false)]
        public string EventContext { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of event notifications. You can set the value to <b>zh-CN</b>, which indicates that event notifications are sent in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The risk level of the events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Notice</b>: events that trigger notifications, including events at the <b>Notice</b>, <b>Optimization</b>, <b>Warn</b>, and <b>Critical</b> levels.</description></item>
        /// <item><description><b>Optimization</b>: events that trigger optimizations, including events at the <b>Optimization</b>, <b>Warn</b>, and <b>Critical</b> levels.</description></item>
        /// <item><description><b>Warn</b>: events that trigger warnings, including events at the <b>Warn</b> and <b>Critical</b> levels.</description></item>
        /// <item><description><b>Critical</b>: events that trigger critical warnings.</description></item>
        /// </list>
        /// <para>The following content describes the events at each level in detail:</para>
        /// <list type="bullet">
        /// <item><description>Notice: events that are related to database exceptions for which no suggestions are generated.</description></item>
        /// <item><description>Optimization: events for which optimization suggestions are generated based on the status of the database.</description></item>
        /// <item><description>Warn: events that may affect the running of the database.</description></item>
        /// <item><description>Critical: events that affect the running of the database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Optimization</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The minimum interval between consecutive event notifications. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MinInterval")]
        [Validation(Required=false)]
        public string MinInterval { get; set; }

        /// <summary>
        /// <para>The alert severity based on the event type.</para>
        /// <para>Specify this parameter in the following format: <c>{&quot;Event type 1&quot;:&quot;Alert severity&quot;, &quot;Event type 2&quot;:&quot;Alert severity&quot;}</c>.</para>
        /// <para>Valid values of event types:</para>
        /// <list type="bullet">
        /// <item><description><b>AutoScale</b>: auto scaling event.</description></item>
        /// <item><description><b>SQLThrottle</b>: throttling event.</description></item>
        /// <item><description><b>TimeSeriesAbnormal</b>: event for detecting time series anomalies.</description></item>
        /// <item><description><b>SQLOptimize</b>: SQL optimization event.</description></item>
        /// <item><description><b>ResourceOptimize</b>: storage optimization event.</description></item>
        /// </list>
        /// <para>Valid values of alert severities:</para>
        /// <list type="bullet">
        /// <item><description><b>info</b></description></item>
        /// <item><description><b>noticed</b></description></item>
        /// <item><description><b>warning</b></description></item>
        /// <item><description><b>critical</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AutoScale&quot;:&quot;critical&quot;,&quot;SQLThrottle&quot;:&quot;info&quot;,&quot;TimeSeriesAbnormal&quot;:&quot;warning&quot;}</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

    }

}
