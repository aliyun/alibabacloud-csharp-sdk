// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnWafDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the header that records the IP address to be obtained. If the default header is selected, the value of this parameter is empty. If a custom header is selected, the value of this parameter is the value specified by the user. Separate multiple values with commas (,). You can specify a maximum of five values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X-Forwarded-For</para>
        /// </summary>
        [NameInMap("ClientIpTag")]
        [Validation(Required=false)]
        public string ClientIpTag { get; set; }

        /// <summary>
        /// <para>The protection status of the domain name. Valid values: on, off, and empty string.</para>
        /// <list type="bullet">
        /// <item><description>When you add a domain name, the value of this parameter is <b>on</b>, and the value of ClientIpTag takes effect, which is empty if the default header is selected and is the value specified by the user if a custom header is selected.</description></item>
        /// <item><description>When you delete a domain name, the value of this parameter is <b>off</b>, and the value of ClientIpTag does not take effect.</description></item>
        /// <item><description>When you only modify the value of ClientIpTag, the value of DefenseStatus is an empty string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DefenseStatus")]
        [Validation(Required=false)]
        public string DefenseStatus { get; set; }

        /// <summary>
        /// <para>The protected domain names for which you want to change the protection status. You can specify up to 50 domain names. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example2.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

    }

}
