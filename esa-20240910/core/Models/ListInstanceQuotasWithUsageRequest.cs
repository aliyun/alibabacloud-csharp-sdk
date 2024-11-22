// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasWithUsageRequest : TeaModel {
        /// <summary>
        /// <para>The plan ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The quota names in the plan. Separate the quota names with commas (,). You can query up to 10 quota names at a time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>customHttpCert</b>: the custom certificates.</description></item>
        /// <item><description><b>transition_rule</b>: the transform rules.</description></item>
        /// <item><description><b>waiting_room</b>: the waiting rooms.</description></item>
        /// <item><description><b>https|rule_quota</b>: the SSL/TLS rules.</description></item>
        /// <item><description><b>cache_rules|rule_quota</b>: the cache rules.</description></item>
        /// <item><description><b>configuration_rules|rule_quota</b>: the configuration rules.</description></item>
        /// <item><description><b>redirect_rules|rule_quota</b>: the redirect rules.</description></item>
        /// <item><description><b>compression_rules|rule_quota</b>: the compression rules.</description></item>
        /// <item><description><b>origin_rules|rule_quota</b>: the origin rules.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customHttpCert</para>
        /// </summary>
        [NameInMap("QuotaNames")]
        [Validation(Required=false)]
        public string QuotaNames { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232223****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
