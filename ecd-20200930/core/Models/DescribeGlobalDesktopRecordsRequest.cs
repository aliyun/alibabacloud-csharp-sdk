// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalDesktopRecordsRequest : TeaModel {
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud desktops. You can specify up to 100 IDs.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// </summary>
        [NameInMap("DesktopStatusList")]
        [Validation(Required=false)]
        public List<string> DesktopStatusList { get; set; }

        /// <summary>
        /// <para>The desktop type. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the IDs of the supported desktop types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time must be in UTC and in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The interval between the start and end times cannot exceed 30 days.</para>
        /// <list type="bullet">
        /// <item><description>Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-31T06:56:45Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the end user.</para>
        /// <list type="bullet">
        /// <item><description><para>Asc: ascending order</para>
        /// </description></item>
        /// <item><description><para>Desc: descending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TestUser</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("ExcludeDesktopStatusList")]
        [Validation(Required=false)]
        public List<string> ExcludeDesktopStatusList { get; set; }

        /// <summary>
        /// <para>The ID of the office site.</para>
        /// <list type="bullet">
        /// <item><description><para>China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para>Singapore</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. If you do not specify this parameter, the results are sorted by creation time in descending order. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>uptime</c>: Sorts the results by cloud desktop uptime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uptime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number to return.<br>Default value: 1.<br></para>
        /// <list type="bullet">
        /// <item><description>Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <list type="bullet">
        /// <item><description><para>Shanghai</para>
        /// </description></item>
        /// <item><description><para>Singapore</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-3mtuc28rx95lx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The query scope. This parameter is empty by default. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ADVANCED</c>: Queries statistical records, such as connection duration.</para>
        /// </description></item>
        /// <item><description><para>postPaid: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>monthPackage: monthly time-based package.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADVANCED</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The sort order. The default is <c>Asc</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time must be in UTC and in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23T04:10:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud desktop. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>monthPackage</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

    }

}
