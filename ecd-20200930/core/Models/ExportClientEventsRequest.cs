// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportClientEventsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The cloud computer name.</para>
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
        /// <para>The type of the event that you want to query. If you provide multiple values for EventTypes, the response will include events of all the specified types. If you provide no values for EventTypes and EventType, the response will include all events in the designated region.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DESKTOP_STOP: the shutdown event.</description></item>
        /// <item><description>GET_LITE_CONNECTION_TICKET: the event of retrieving the connection ticket.</description></item>
        /// <item><description>DESKTOP_DISCONNECT: the session disconnection event.</description></item>
        /// <item><description>CLIENT_LOGIN: the user logon event.</description></item>
        /// <item><description>GET_CONNECTION_TICKET: the connection credential retrieval event.</description></item>
        /// <item><description>DESKTOP_REBOOT: the restart event.</description></item>
        /// <item><description>DESKTOP_CONNECT: the session establishment event.</description></item>
        /// <item><description>DESKTOP_START: the start event.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_LOGIN</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The types of the events that you want to query. You can include multiple event types, and the response will return events matching the specified types or all events if none are specified.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// <para>The language displayed on the frontend page. The backend uses this setting to define the language of exported files.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>en-GB: British English.</description></item>
        /// </list>
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
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The office network name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
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
