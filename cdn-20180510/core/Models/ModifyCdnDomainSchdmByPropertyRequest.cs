// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ModifyCdnDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name for which you want to change the acceleration region. You can specify only one domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The information about the acceleration region. {&quot;coverage&quot;:&quot;overseas&quot;}</para>
        /// <para>Valid values for coverage:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: global (excluding the Chinese mainland)</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;coverage&quot;:&quot;overseas&quot;}</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

    }

}
