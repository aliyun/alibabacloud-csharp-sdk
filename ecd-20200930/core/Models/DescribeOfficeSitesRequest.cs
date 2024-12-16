// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeOfficeSitesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network IDs. You can specify the IDs of 1 to 100 office networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public List<string> OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The account type of the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SIMPLE: convenience account</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>AD_CONNECTOR: enterprise Active Directory (AD) account</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The security protection setting of the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SASE: SASE is configured.</description></item>
        /// <item><description>OFF: No security protection setting is configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SASE</para>
        /// </summary>
        [NameInMap("SecurityProtection")]
        [Validation(Required=false)]
        public string SecurityProtection { get; set; }

        /// <summary>
        /// <para>The office network status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>REGISTERING: The office network is being registered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DEREGISTERING: The office network is being deregistered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>REGISTERED: The office network is registered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>NEEDCONFIGTRUST: A trust relationship is required for the office network.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CONFIGTRUSTFAILED: A trust relationship fails to be configured for the office network.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DEREGISTERED: The office network is deregistered.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ERROR: One or more configurations of the office network are invalid.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CONFIGTRUSTING: A trust relationship is being configured for the office network.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>NEEDCONFIGUSER: Users are required for the office network.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REGISTERED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
