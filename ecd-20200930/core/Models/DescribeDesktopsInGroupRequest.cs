// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsInGroupRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the custom time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("CustomEndTimePeriod")]
        [Validation(Required=false)]
        public long? CustomEndTimePeriod { get; set; }

        /// <summary>
        /// <para>The start time of the custom time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CustomStartTimePeriod")]
        [Validation(Required=false)]
        public long? CustomStartTimePeriod { get; set; }

        /// <summary>
        /// <para>The ID of the shared cloud desktop.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore the deletion flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreDeleted")]
        [Validation(Required=false)]
        public bool? IgnoreDeleted { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page for paging in a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// <item><description>Maximum value: 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to start the next query. An empty value indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to obtain the list of regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
