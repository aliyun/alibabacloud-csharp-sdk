// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalDesktopRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer IDs. You can specify 1 to 100 office network IDs.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        [NameInMap("DesktopStatusList")]
        [Validation(Required=false)]
        public List<string> DesktopStatusList { get; set; }

        /// <summary>
        /// <para>The cloud computer type. You can call the <a href="https://help.aliyun.com/document_detail/188882.html">DescribeDesktopTypes</a> operation to query the IDs of the specifications supported by the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The end time. The interval between the start time and end time can be up to 30 days. Supported formats:</para>
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
        /// <para>The end user ID.</para>
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
        /// <para>The office network IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The sorting field. If this parameter is not provided, results are sorted by creation time in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>uptime: indicates that the cloud computers are sorted by startup duration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uptime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number of the current page.\
        /// Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <list type="bullet">
        /// <item><description>China (Shanghai)</description></item>
        /// <item><description>Singapore</description></item>
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
        /// <para>The query range. This parameter is empty by default. Optional values are:</para>
        /// <list type="bullet">
        /// <item><description>ADVANCED: indicates that statistics such as the connection duration are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADVANCED</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The sorting method. Default value: ascending. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order</description></item>
        /// <item><description>Desc: descending.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The start time. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23T04:10:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The way to purchase cloud computers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prePaid: The monthly purchase is unlimited.</description></item>
        /// <item><description>postPaid: pay-as-you-go</description></item>
        /// <item><description>monthPackage: monthly duration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>monthPackage</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

    }

}
