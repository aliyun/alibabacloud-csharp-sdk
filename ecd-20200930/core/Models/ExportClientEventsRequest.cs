// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportClientEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>If you do not specify a value for this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23T07:11:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The type of event that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DESKTOP_CONNECT: The desktop session is established.</description></item>
        /// <item><description>DESKTOP_DISCONNECT: The desktop session is disconnected.</description></item>
        /// <item><description>DESKTOP_REBOOT: The cloud desktop is restarted.</description></item>
        /// <item><description>CLIENT_AD_LOGIN: The AD user logs on to the client.</description></item>
        /// <item><description>GET_CONNECTION_TICKET: The request to connect to the cloud desktop is sent.</description></item>
        /// <item><description>DESKTOP_START: The cloud desktop is started.</description></item>
        /// <item><description>DESKTOP_STOP: The cloud desktop is stopped.</description></item>
        /// </list>
        /// <para>If you do not specify a value for this parameter, events of all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_LOGIN</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The types of event.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// <para>The language in which the cloud desktop is displayed in the console UI. You can export the list of cloud desktops in the specified language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>zh-CN</c>: Simplified Chinese</description></item>
        /// <item><description><c>en-GB</c>: English (United Kingdom)</description></item>
        /// </list>
        /// <para>Default value: <c>zh-CN</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LangType")]
        [Validation(Required=false)]
        public string LangType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 5000.</description></item>
        /// <item><description>Default value: 5000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>If you do not specify a value for this parameter, all events that occurred before the point in time that you specify for <c>EndTime</c> are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23T04:10:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
