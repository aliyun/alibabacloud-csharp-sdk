// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateWaitingRoomEventRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>html-yets-maqi1111</para>
        /// </summary>
        [NameInMap("CustomPageHtml")]
        [Validation(Required=false)]
        public string CustomPageHtml { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://yywyyw.com">http://yywyyw.com</a></para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DisableSessionRenewalEnable")]
        [Validation(Required=false)]
        public string DisableSessionRenewalEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1719849600</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("JsonResponseEnable")]
        [Validation(Required=false)]
        public string JsonResponseEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enus</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("NewUsersPerMinute")]
        [Validation(Required=false)]
        public string NewUsersPerMinute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PreQueueEnable")]
        [Validation(Required=false)]
        public string PreQueueEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("PreQueueStartTime")]
        [Validation(Required=false)]
        public string PreQueueStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fifo</para>
        /// </summary>
        [NameInMap("QueuingMethod")]
        [Validation(Required=false)]
        public string QueuingMethod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("QueuingStatusCode")]
        [Validation(Required=false)]
        public string QueuingStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RandomPreQueueEnable")]
        [Validation(Required=false)]
        public string RandomPreQueueEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1719763200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalActiveUsers")]
        [Validation(Required=false)]
        public string TotalActiveUsers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89677721098****</para>
        /// </summary>
        [NameInMap("WaitingRoomEventId")]
        [Validation(Required=false)]
        public long? WaitingRoomEventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("WaitingRoomType")]
        [Validation(Required=false)]
        public string WaitingRoomType { get; set; }

    }

}
