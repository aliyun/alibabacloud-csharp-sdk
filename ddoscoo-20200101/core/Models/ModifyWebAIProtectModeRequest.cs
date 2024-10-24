// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAIProtectModeRequest : TeaModel {
        /// <summary>
        /// <para>The details of the Intelligent Protection policy. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AiTemplate</b>: the level of the Intelligent Protection policy. This field is required and must be of the STRING type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level30</b>: the Low level</description></item>
        /// <item><description><b>level60</b>: the Normal level</description></item>
        /// <item><description><b>level90</b>: the Strict level</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>AiMode</b>: the mode of the Intelligent Protection policy. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>watch</b>: the Warning mode</description></item>
        /// <item><description><b>defense</b>: the Defense mode</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AiTemplate&quot;:&quot;level60&quot;,&quot;AiMode&quot;:&quot;defense&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for a domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
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

    }

}
