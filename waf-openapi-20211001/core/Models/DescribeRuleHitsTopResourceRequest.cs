// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopResourceRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: seconds. If you do not specify this parameter, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1665386340</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1:</b> outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The type of rules that are triggered by the protected object. By default, this parameter is not specified and all types of rules are queried.</para>
        /// <list type="bullet">
        /// <item><description><b>blacklist:</b> IP address blacklist rules.</description></item>
        /// <item><description><b>custom:</b> custom rules.</description></item>
        /// <item><description><b>antiscan:</b> scan protection rules.</description></item>
        /// <item><description><b>cc_system:</b> HTTP flood protection rules.</description></item>
        /// <item><description><b>region_block:</b> region blacklist rules.</description></item>
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
