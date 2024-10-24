// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebCCGlobalSwitchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the HTTP flood mitigation feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b></description></item>
        /// <item><description><b>close</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("CcGlobalSwitch")]
        [Validation(Required=false)]
        public string CcGlobalSwitch { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
