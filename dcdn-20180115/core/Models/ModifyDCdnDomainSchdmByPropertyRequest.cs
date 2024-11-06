// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDCdnDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the accelerated domain for which you want to change the acceleration region. You can specify only one domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The region where the acceleration service is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: global (excluding mainland China)</description></item>
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
