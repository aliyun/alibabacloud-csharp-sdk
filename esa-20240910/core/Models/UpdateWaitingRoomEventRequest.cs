// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateWaitingRoomEventRequest : TeaModel {
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
        /// <para><a href="http://yywyyw.com">http://yywyyw.com</a></para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <para>The enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables the waiting room event.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables the waiting room event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The timestamp of the event end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719849600</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable JSON response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <para>The default language setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enus</b>: English.</description></item>
        /// <item><description><b>zhcn</b>: Simplified Chinese.</description></item>
        /// <item><description><b>zhhk</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enus</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the waiting room event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试事件2</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of new users per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pre-queuing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PreQueueEnable")]
        [Validation(Required=false)]
        public string PreQueueEnable { get; set; }

        /// <summary>
        /// <para>The timestamp of the pre-queuing start time.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>fifo</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <para>The waiting room status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b></description></item>
        /// <item><description><b>202</b></description></item>
        /// <item><description><b>429</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("QueuingStatusCode")]
        [Validation(Required=false)]
        public string QueuingStatusCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable random pre-queuing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RandomPreQueueEnable")]
        [Validation(Required=false)]
        public string RandomPreQueueEnable { get; set; }

        /// <summary>
        /// <para>The user session duration, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The timestamp of the event start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of active users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <para>The waiting room event ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRoomEvents</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89677721098****</para>
        /// </summary>
        [NameInMap("WaitingRoomEventId")]
        [Validation(Required=false)]
        public long? WaitingRoomEventId { get; set; }

        /// <summary>
        /// <para>The type of the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: default type.</description></item>
        /// <item><description><b>custom</b>: custom type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("WaitingRoomType")]
        [Validation(Required=false)]
        public string WaitingRoomType { get; set; }

    }

}
