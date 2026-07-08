// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopRuleIdRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: seconds. If you do not specify this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665386280</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>Specifies whether to aggregate rule hits by protected object.</para>
        /// <list type="bullet">
        /// <item><description><b>true (default)</b>: Aggregates rule hits by protected object. In this case, rule hits are counted based on individual rules only, and the Resource value in the response is empty.</description></item>
        /// <item><description><b>false</b>: Does not aggregate rule hits by protected object. In this case, rule hits are counted based on both protected objects and rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsGroupResource")]
        [Validation(Required=false)]
        public string IsGroupResource { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of rule hit by the protected object. By default, this parameter is not specified, which indicates that all rules are displayed.</para>
        /// <list type="bullet">
        /// <item><description><para><b>blacklist</b>: IP blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: Custom rule.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: Scan protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>cc_system</b>: HTTP flood mitigation rule.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: Location blacklist.</para>
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
        /// <para>The beginning of the time range to query. Unit: seconds.</para>
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
