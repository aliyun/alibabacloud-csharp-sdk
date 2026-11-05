// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryConnectionReportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app instance group, which is used to filter data for a specified app instance group. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the ID. If you do not specify this parameter, data is not filtered by app instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the business region, which is used to filter report data. You can call <a href="~~ListRegions~~">ListRegions</a> to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end time of the statistics. <b>Required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The value cannot be earlier than <c>StartDate</c>. The statistical interval includes the start time but excludes the end time. The time span cannot exceed 60 months. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page number to query. We recommend that you explicitly specify a value starting from <c>1</c>. If you do not specify this parameter, the service processes the request as the first page, but the response may echo <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 200. If the value exceeds 1,500, it is processed as 1,500.</para>
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
        /// <item><description><c>CloudApp</c>: Wuying cloud app.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise edition workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Team edition Linggou container workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Dedicated edition Linggou container workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud phone.</description></item>
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
        /// <para>The start time of the statistics. <b>Required</b>. Format: <c>yyyy-MM-dd HH:mm:ss</c>. The statistical interval includes the start time but excludes the end time. The time span cannot exceed 60 months. The string itself does not carry a time zone and is interpreted in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
