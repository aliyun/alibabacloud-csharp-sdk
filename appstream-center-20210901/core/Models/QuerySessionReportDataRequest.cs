// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QuerySessionReportDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specified app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the business region, which is used to filter report data. You can call the <a href="~~ListRegions~~">ListRegions</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end time of the statistics. This parameter is required. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The end time cannot be earlier than <c>StartDate</c>. The query span must meet the limit corresponding to <c>StatDateType</c>. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number of the page to query. Specify this parameter starting from <c>1</c>. If you do not specify this parameter, the first page is queried, but the response may return <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 200. If the specified value is greater than 1500, 1500 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is optional. If you do not specify this parameter, data is queried based on the Wuying Cloud App caliber.</para>
        /// <para>Specify the value in the exact case shown below. Data that does not match the specified value is not returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: Wuying Cloud App.</description></item>
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
        /// <para>The start time of the statistics. This parameter is required. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The <c>1d</c> granularity aggregates data by date, while other granularities aggregate data down to the minute. The query includes both the start and end boundaries. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical granularity. This parameter is required.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1m</c>: aggregates data by 1 minute. The maximum query span is 1 day.</description></item>
        /// <item><description><c>30m</c>: aggregates data by 30 minutes. The maximum query span is 1 day.</description></item>
        /// <item><description><c>6h</c>: aggregates data by 6 hours. The maximum query span is 15 days.</description></item>
        /// <item><description><c>1d</c>: aggregates data by day. The maximum query span is 180 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("StatDateType")]
        [Validation(Required=false)]
        public string StatDateType { get; set; }

    }

}
