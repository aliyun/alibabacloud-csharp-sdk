// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeFieldRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The key of the global configuration. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>soar_filed_tags</b>: Obtains the input field template for a playbook.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>soar_filed_tags</para>
        /// </summary>
        [NameInMap("QueryKey")]
        [Validation(Required=false)]
        public string QueryKey { get; set; }

    }

}
