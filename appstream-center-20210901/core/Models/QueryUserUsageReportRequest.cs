// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserUsageReportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specified app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group. To skip this filter, omit the parameter. An empty string is different from an omitted parameter and is used as a filter value in the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the business region, which is used to filter report data. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID. To skip this filter, omit the parameter. An empty string is different from an omitted parameter and is used as a filter value in the query.</para>
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
        /// <para>The end time of the statistics. <b>This parameter is required. You must specify both <c>StartDate</c> and <c>EndDate</c></b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The time is in Beijing time (UTC+8). Specify the time in Beijing time without appending <c>Z</c> or a time zone offset. The operation filters calendar day data based on the provided calendar dates without time zone conversion. The hour, minute, and second parts are not involved in day-level filtering.</para>
        /// <para>The interval between the start and end times calculated by full months must not exceed 60 months. Make sure that <c>EndDate</c> is not earlier than <c>StartDate</c>. The current operation does not independently verify the chronological order of the times. A reversed date range may return empty data. Do not rely on parameter errors to identify this situation.</para>
        /// <para>If either time parameter is missing, the format is incorrect, or the range exceeds the limit, <c>InvalidParameter.StartDate/EndDate</c> (HTTP status code: 400) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number to query. Specify a value starting from <c>1</c>. If you do not specify this parameter, the service processes the request as the first page, but the response may echo <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: <c>200</c>. If the value is greater than <c>1500</c>, the actual query processes it as <c>1500</c>. Specify a value from 1 to 1,500. The <c>PageSize</c> field in the response returns the echo request value, which does not necessarily mean that this value is adopted or that this number of records is actually returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. <b>This parameter must be explicitly specified</b>. The value is not case-sensitive. If this parameter is not provided or an unrecognized type is specified, <c>InvalidParameter.ProductType</c> (HTTP status code: 400) is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudGame</c>: Cloud gaming.</description></item>
        /// <item><description><c>CloudApp</c>: Wuying Cloud App.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud browser.</description></item>
        /// <item><description><c>CloudDesktop</c>: Cloud desktop.</description></item>
        /// <item><description><c>ImageBuilder</c>: Image builder.</description></item>
        /// <item><description><c>ImageValidate</c>: Image validation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud phone.</description></item>
        /// <item><description><c>GpuRender</c>: GPU rendering.</description></item>
        /// <item><description><c>AndroidGpuRender</c>: Cloud phone GPU rendering.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise workstation.</description></item>
        /// <item><description><c>GpuProxy</c>: GPU remote rendering proxy.</description></item>
        /// <item><description><c>GpuCache</c>: GPU remote rendering cache.</description></item>
        /// <item><description><c>AIAgent</c>: AI agent service.</description></item>
        /// <item><description><c>HostedDesktop</c>: Hosted computer.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Business Edition container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Team Edition container workstation.</description></item>
        /// </list>
        /// <para>The query returns only existing statistical records for the current account within the specified product and time range. Specifying a recognized type does not necessarily mean that report data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the statistics. <b>This parameter is required. You must specify both <c>StartDate</c> and <c>EndDate</c></b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The time is in Beijing time (UTC+8). Specify the time in Beijing time without appending <c>Z</c> or a time zone offset. The operation filters calendar day data based on the provided calendar dates without time zone conversion. The hour, minute, and second parts are not involved in day-level filtering.</para>
        /// <para>The interval between the start and end times calculated by full months must not exceed 60 months. Make sure that <c>EndDate</c> is not earlier than <c>StartDate</c>. The current operation does not independently verify the chronological order of the times. A reversed date range may return empty data. Do not rely on parameter errors to identify this situation.</para>
        /// <para>If either time parameter is missing, the format is incorrect, or the range exceeds the limit, <c>InvalidParameter.StartDate/EndDate</c> (HTTP status code: 400) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The ID of the end user, which is used to precisely filter users. If you do not specify this parameter, data is not filtered by user. To skip this filter, omit the parameter. An empty string is different from an omitted parameter and is used as a filter value in the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
