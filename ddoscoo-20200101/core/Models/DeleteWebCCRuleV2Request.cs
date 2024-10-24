// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteWebCCRuleV2Request : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The source of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual</b> (default): manually created.</description></item>
        /// <item><description><b>clover</b>: automatically created. Specify this value when you want to delete intelligent protection rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The names of the rules that you want to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;trdsss\&quot;]</para>
        /// </summary>
        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public string RuleNames { get; set; }

    }

}
