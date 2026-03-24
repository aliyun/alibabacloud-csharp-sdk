// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopRuleIdRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: seconds. If you do not specify this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665386280</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the WAF instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to aggregate the number of rule hits by protected object.</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): The number of rule hits is aggregated for each protection rule. In this case, the <b>Resource</b> parameter in the response is empty.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The number of rule hits is not aggregated. Statistics are collected for each protected object and protection rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsGroupResource")]
        [Validation(Required=false)]
        public string IsGroupResource { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Outside Chinese mainland.</para>
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
        /// <para>The protected object.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of rule that was hit. If you do not specify this parameter, statistics for all rule types are returned.</para>
        /// <list type="bullet">
        /// <item><description><para><b>blacklist</b>: The request hit a rule in the IP address blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: The request hit a custom rule.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: The request hit a scan protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>cc_system</b>: The request hit an HTTP flood protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: The request hit a rule in the Location Blacklist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blacklist</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665331200</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

    }

}
