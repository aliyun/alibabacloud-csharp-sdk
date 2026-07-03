// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertSourceRequest : TeaModel {
        /// <summary>
        /// <para>The end of the query time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The threat levels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>serious</c>: High</para>
        /// </description></item>
        /// <item><description><para><c>suspicious</c>: Medium</para>
        /// </description></item>
        /// <item><description><para><c>remind</c>: Low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;serious&quot;,&quot;suspicious&quot;,&quot;remind&quot;]</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public List<string> Level { get; set; }

        /// <summary>
        /// <para>The region of the data management center for threat analysis. Select the data management center that corresponds to the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: for assets in the Chinese mainland and Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: for assets in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member whose data you want to view. An administrator uses this parameter to view data from the perspective of a specific member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: View data for the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: View data for all accounts in the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The start of the query time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
