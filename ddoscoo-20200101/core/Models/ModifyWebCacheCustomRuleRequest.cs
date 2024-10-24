// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebCacheCustomRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name, and the domain name must be associated with an instance that uses the Enhanced function plan. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The details of the custom rule. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Name</b>: the name of the rule. This field is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>Uri</b>: the path to the cached page. This field is required and must be of the STRING type.</para>
        /// </description></item>
        /// <item><description><para><b>Mode</b>: the cache mode. This field is required and must be of the STRING type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: uses the standard mode.</description></item>
        /// <item><description><b>aggressive</b>: uses the enhanced mode.</description></item>
        /// <item><description><b>bypass</b>: No data is cached.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CacheTtl</b>: the expiration time of the page cache. This field is required and must be of the INTEGER type. Unit: seconds.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;: &quot;test&quot;,&quot;Uri&quot;: &quot;/a&quot;,&quot;Mode&quot;: &quot;standard&quot;,&quot;CacheTtl&quot;: 3600}]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
