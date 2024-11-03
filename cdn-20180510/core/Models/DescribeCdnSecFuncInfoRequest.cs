// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSecFuncInfoRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Chinese</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the security feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CipherSuiteGroupCustomize: custom cipher suite.</description></item>
        /// <item><description>CipherSuiteGroupStrict: dustom cipher suite.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CipherSuiteGroupCustomize</para>
        /// </summary>
        [NameInMap("SecFuncType")]
        [Validation(Required=false)]
        public string SecFuncType { get; set; }

    }

}
