// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryDauReportDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specific app instance group. You can call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID. If this parameter is not specified, data is not filtered by app instance group.</para>
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
        /// <para>The end time of the statistics period. This parameter is required. Format: yyyy-MM-dd HH:mm:ss. The value cannot be earlier than StartDate. The service extracts the natural day in the yyyy-MM-dd format. The string does not contain a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-30 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number to query. Specify a value starting from 1. If this parameter is not specified, the service processes the request as the first page, but the response may return 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: 200. If the specified value is greater than 1,500, the value is processed as 1,500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. This parameter is optional. If this parameter is not specified or is unrecognized, the query defaults to CloudApp.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud App.</description></item>
        /// <item><description>CloudBrowser: Cloud browser.</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation.</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation.</description></item>
        /// <item><description>WuyingWorkstationTeam: Linggou Team Edition container workstation.</description></item>
        /// <item><description>WuyingWorkstationBusiness: Linggou Dedicated Edition container workstation.</description></item>
        /// <item><description>AndroidCloud: Cloud phone.</description></item>
        /// <item><description>AIAgent: AgentBay (AI agent).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the statistics period. This parameter is required. Format: yyyy-MM-dd HH:mm:ss. The service extracts the natural day in the yyyy-MM-dd format. The date range is inclusive and cannot exceed 180 days. The string does not contain a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
