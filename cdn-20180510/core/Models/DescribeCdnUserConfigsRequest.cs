// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The configuration that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domain_business_control</b>: user configurations</description></item>
        /// <item><description><b>waf</b>: Web Application Firewall (WAF) configurations</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain_business_control</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
