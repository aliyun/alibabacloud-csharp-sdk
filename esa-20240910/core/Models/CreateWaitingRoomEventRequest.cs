// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWaitingRoomEventRequest : TeaModel {
        /// <summary>
        /// <para>The custom waiting room page content. This parameter is required when the waiting room type is set to custom. The content must use Base64 encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SGVsbG8gd29ybGQ=</para>
        /// </summary>
        [NameInMap("CustomPageHtml")]
        [Validation(Required=false)]
        public string CustomPageHtml { get; set; }

        /// <summary>
        /// <para>The description of the waiting room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <para>The waiting room switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The event end timestamp, such as 1705044735.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719849600</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable JSON response. When enabled, requests with an Accept header containing &quot;application/json&quot; return JSON data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <para>The language of the waiting room page. This parameter is required when the waiting room type is set to default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enus</b>: English.</description></item>
        /// <item><description><b>zhcn</b>: Simplified Chinese.</description></item>
        /// <item><description><b>zhhk</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zhcn</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the waiting room event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waitingroom_example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of new users per minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pre-queuing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PreQueueEnable")]
        [Validation(Required=false)]
        public string PreQueueEnable { get; set; }

        /// <summary>
        /// <para>The pre-queuing start timestamp, which must be at least 5 minutes earlier than the event start timestamp, such as 1705044735.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("PreQueueStartTime")]
        [Validation(Required=false)]
        public string PreQueueStartTime { get; set; }

        /// <summary>
        /// <para>The queuing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>random</b>: random.</description></item>
        /// <item><description><b>fifo</b>: first-in, first-out.</description></item>
        /// <item><description><b>passthrough</b>: passthrough.</description></item>
        /// <item><description><b>reject-all</b>: reject all.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>random</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <para>The waiting room status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b></description></item>
        /// <item><description><b>202</b></description></item>
        /// <item><description><b>429</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("QueuingStatusCode")]
        [Validation(Required=false)]
        public string QueuingStatusCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable random pre-queuing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RandomPreQueueEnable")]
        [Validation(Required=false)]
        public string RandomPreQueueEnable { get; set; }

        /// <summary>
        /// <para>The session duration, in minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The event start timestamp, such as 1705044735.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of active users.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <para>The waiting room ID. You can call the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRooms</a> operation to obtain the waiting room ID. The waiting room must belong to the site specified by SiteId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a51d5bc6460887abd1291dc7d4db28b</para>
        /// </summary>
        [NameInMap("WaitingRoomId")]
        [Validation(Required=false)]
        public string WaitingRoomId { get; set; }

        /// <summary>
        /// <para>The type of the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: default type.</description></item>
        /// <item><description><b>custom</b>: custom type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WaitingRoomType")]
        [Validation(Required=false)]
        public string WaitingRoomType { get; set; }

    }

}
