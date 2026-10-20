// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateWaitingRoomShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the custom cookie.</para>
        /// 
        /// <b>Example:</b>
        /// <para>__aliwaitingroom_example</para>
        /// </summary>
        [NameInMap("CookieName")]
        [Validation(Required=false)]
        public string CookieName { get; set; }

        /// <summary>
        /// <para>The custom content of the waiting room page. This parameter is required when the waiting room type is custom. The content requires Base64 encoding.</para>
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
        /// <para>Special event queue page</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Disables session renewal.</description></item>
        /// <item><description><b>off</b>: Enables session renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <para>The status of the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables the waiting room.</description></item>
        /// <item><description><b>off</b>: Disables the waiting room.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The hostnames and paths.</para>
        /// </summary>
        [NameInMap("HostNameAndPath")]
        [Validation(Required=false)]
        public string HostNameAndPathShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable JSON responses. If this feature is enabled and the Accept request header contains &quot;application/json&quot;, JSON data is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables the feature.</description></item>
        /// <item><description><b>off</b>: Disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <para>The language of the waiting room page. This parameter is required when the waiting room type is default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enus</b>: English</description></item>
        /// <item><description><b>zhcn</b>: Simplified Chinese</description></item>
        /// <item><description><b>zhhk</b>: Traditional Chinese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zhcn</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the waiting room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>holiday-promotion-waiting-room</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of new users per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <para>Specifies whether to queue all users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables the feature.</description></item>
        /// <item><description><b>off</b>: Disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("QueueAllEnable")]
        [Validation(Required=false)]
        public string QueueAllEnable { get; set; }

        /// <summary>
        /// <para>The queuing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>random</b>: random</description></item>
        /// <item><description><b>fifo</b>: first in, first out (FIFO)</description></item>
        /// <item><description><b>passthrough</b>: passthrough</description></item>
        /// <item><description><b>reject-all</b>: reject all</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>random</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the waiting room. Valid values:</para>
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
        /// <para>The duration of a user session, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to query the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The total number of active users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <para>The ID of the waiting room. You can call the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRooms</a> operation to query the waiting room ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a51d5bc6460887abd129****</para>
        /// </summary>
        [NameInMap("WaitingRoomId")]
        [Validation(Required=false)]
        public string WaitingRoomId { get; set; }

        /// <summary>
        /// <para>The type of the waiting room. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: default type</description></item>
        /// <item><description><b>custom</b>: custom type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WaitingRoomType")]
        [Validation(Required=false)]
        public string WaitingRoomType { get; set; }

    }

}
