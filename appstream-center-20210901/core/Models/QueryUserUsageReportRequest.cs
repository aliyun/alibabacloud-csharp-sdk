// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserUsageReportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group. This parameter is used to filter data for a specified app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the business region. This parameter is used to filter report data. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The filter condition for the user connection status. The value is not case-sensitive. An unrecognized value is equivalent to not filtering by connection status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Connected</c>: At least one currently connected session exists.</description></item>
        /// <item><description><c>Disconnected</c>: The session binding is retained, but no currently connected session exists.</description></item>
        /// <item><description><c>Unbound</c>: No session binding exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connected</para>
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// <para>The end time of the statistics. <b>Required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The end time cannot be earlier than StartDate. The service converts the time to <c>yyyyMMdd</c> and calculates the statistics by natural days in a closed interval. The hours, minutes, and seconds are not involved in the day-level filtering. The time span cannot exceed 60 months. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number to query. Specify a value starting from 1. If you do not specify this parameter, the service processes the request as the first page, but the response may return 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 200. If the value is greater than 1,500, it is processed as 1,500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. <b>Required</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud App.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud Browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Edition workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Team Edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Dedicated Edition Linggou container workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud Phone.</description></item>
        /// <item><description><c>AIAgent</c>: AgentBay (AI agent).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the statistics. <b>Required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The service converts the time to <c>yyyyMMdd</c> and calculates the statistics by natural days in a closed interval. The hours, minutes, and seconds are not involved in the day-level filtering. The time span cannot exceed 60 months. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The ID of the end user. This parameter is used to accurately filter users. If you do not specify this parameter, data is not filtered by user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
