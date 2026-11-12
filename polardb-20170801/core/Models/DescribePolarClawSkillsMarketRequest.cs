// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillsMarketRequest : TeaModel {
        /// <summary>
        /// <para>The sorting condition. DOWNLOAD_COUNT indicates sorting by download count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNLOAD_COUNT</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query all available regions for the current account, including region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The skill name to search by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarclawhub</para>
        /// </summary>
        [NameInMap("SearchBySkillName")]
        [Validation(Required=false)]
        public string SearchBySkillName { get; set; }

        /// <summary>
        /// <para>The tag name to search by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDB</para>
        /// </summary>
        [NameInMap("SearchByTagName")]
        [Validation(Required=false)]
        public string SearchByTagName { get; set; }

        /// <summary>
        /// <para>The source of the skill. SELF indicates private skills of the current user, and PUBLIC indicates public skills.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
