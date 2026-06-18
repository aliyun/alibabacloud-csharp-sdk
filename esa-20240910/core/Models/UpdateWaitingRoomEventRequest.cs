// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateWaitingRoomEventRequest : TeaModel {
        /// <summary>
        /// <para>The content of the custom waiting room page. You must specify this parameter if you set WaitingRoomType to custom. The content must be Base64-encoded.</para>
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
        /// <item><description><para>on</para>
        /// </description></item>
        /// <item><description><para>off</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the waiting room event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c></para>
        /// </description></item>
        /// <item><description><para><c>off</c></para>
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
        /// <para>The end time of the event. This value is a UNIX timestamp.</para>
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
        /// <item><description><para>on</para>
        /// </description></item>
        /// <item><description><para>off</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <para>The default language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>enus</c>: English.</para>
        /// </description></item>
        /// <item><description><para><c>zhcn</c>: Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para><c>zhhk</c>: Traditional Chinese.</para>
        /// </description></item>
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
        /// <para>Test event 2</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of new users per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pre-queuing.</para>
        /// <list type="bullet">
        /// <item><description><para>on</para>
        /// </description></item>
        /// <item><description><para>off</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PreQueueEnable")]
        [Validation(Required=false)]
        public string PreQueueEnable { get; set; }

        /// <summary>
        /// <para>The start time for pre-queuing.</para>
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
        /// <item><description><para>random: Users gain access to the origin randomly, regardless of the arrival time.</para>
        /// </description></item>
        /// <item><description><para>fifo: Users gain access to the origin in order of arrival.</para>
        /// </description></item>
        /// <item><description><para>passthrough: Users pass through the waiting room and go straight to the origin.</para>
        /// </description></item>
        /// <item><description><para>reject-all: All requests are blocked from accessing the origin.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fifo</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <para>The HTTP status code to return while a user is in the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>200</para>
        /// </description></item>
        /// <item><description><para>202</para>
        /// </description></item>
        /// <item><description><para>429</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("QueuingStatusCode")]
        [Validation(Required=false)]
        public string QueuingStatusCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable random queuing.</para>
        /// <list type="bullet">
        /// <item><description><para>on</para>
        /// </description></item>
        /// <item><description><para>off</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RandomPreQueueEnable")]
        [Validation(Required=false)]
        public string RandomPreQueueEnable { get; set; }

        /// <summary>
        /// <para>The maximum duration for which a session remains valid after a user leaves the origin. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The start time of the event. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The maximum number of active users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <para>The ID of the waiting room event, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRoomEvents</a> operation.</para>
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
        /// <item><description><para>default</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
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
