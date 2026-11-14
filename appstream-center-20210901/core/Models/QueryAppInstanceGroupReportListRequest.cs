// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryAppInstanceGroupReportListRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition for the delivery group ID, which matches the exact ID. If this parameter is not specified, the results are not filtered by ID. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The filter condition for the delivery group name, which supports inclusion matching. If this parameter is not specified, the results are not filtered by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D workstation</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The business region ID of the delivery group. You can call <a href="~~ListRegions~~">ListRegions</a> to obtain the ID. If this parameter is not specified, the results are not filtered by business region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The end date of the statistics. Format: <c>yyyyMMdd</c>. This parameter must be specified in pairs with StartDate and cannot be earlier than the start date. The string itself does not carry a time zone and is interpreted as a natural date in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260930</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The ID of the end user, which is used to filter delivery groups based on the current valid authorization relationship. Before calling this operation, make sure that the user has at least one valid authorization. If the user does not have a valid authorization, the current version does not narrow down the results based on this parameter. If this parameter is not specified, the results are not filtered by user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The page number to query. Specify this parameter starting from <c>1</c>. If this parameter is not specified, the service processes the request as the first page, but the response may return <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 200. The current operation does not have an additional upper limit for a single page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID for OpenAPI access, which is used for request authentication and routing. To filter business data by region, use BizRegionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start date of the statistics. Format: <c>yyyyMMdd</c>. This parameter must be specified in pairs with EndDate, and the interval includes the start and end dates. The string itself does not carry a time zone and is interpreted as a natural date in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260901</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical date for a single day. Format: <c>yyyyMMdd</c>. If this parameter is specified together with StartDate and EndDate, the results must meet both the single-day and interval conditions. The string itself does not carry a time zone and is interpreted as a natural date in the Asia/Shanghai (UTC+8) time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260901</para>
        /// </summary>
        [NameInMap("StatDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

        /// <summary>
        /// <para>The list of delivery group statuses. Multiple values have an OR relationship. Unrecognized values do not participate in filtering. If all values are unrecognized, it is equivalent to not filtering by status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>DEPLOYING</c>: deploying</description></item>
        /// <item><description><c>DEPLOYED</c>: deployed but not published</description></item>
        /// <item><description><c>PUBLISHED</c>: published and available to provide services based on the current configuration</description></item>
        /// <item><description><c>STOPPING</c>: stopping</description></item>
        /// <item><description><c>STOPPED</c>: stopped</description></item>
        /// <item><description><c>MAINTAINING</c>: maintaining</description></item>
        /// <item><description><c>FAILED</c>: deployment or execution failed</description></item>
        /// <item><description><c>MAINTAIN_FAILED</c>: maintenance failed</description></item>
        /// <item><description><c>DELETING</c>: deleting</description></item>
        /// <item><description><c>DELETED</c>: deleted</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
