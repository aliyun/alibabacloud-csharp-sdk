// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaPendingDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-computer</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100</description></item>
        /// <item><description>Default value: 20</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the <c>NextToken</c> value returned from the previous call to this operation. You do not need to specify this parameter for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the office network. You can call the <a href="https://help.aliyun.com/document_detail/216071.html">DescribeOfficeSites</a> operation to obtain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai+dir-428216****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions supported by cloud computers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information about the image upgrade task. You can call the <a href="https://help.aliyun.com/document_detail/437001.html">DescribeFotaTasks</a> operation to obtain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aot-c4khwrp9ocml4****</para>
        /// </summary>
        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public string TaskUid { get; set; }

    }

}
