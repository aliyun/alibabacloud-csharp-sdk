// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForReserveDropListDomainRequest : TeaModel {
        /// <summary>
        /// <para>The contact template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public string ContactTemplateId { get; set; }

        /// <summary>
        /// <para>The domain list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForReserveDropListDomainRequestDomains> Domains { get; set; }
        public class SaveBatchTaskForReserveDropListDomainRequestDomains : TeaModel {
            /// <summary>
            /// <para>The first custom DNS server.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required only if you set <b>AliyunDns</b> to <b>false</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Make sure that your custom DNS servers are valid. Otherwise, the domain reservation may fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ns11.big<a href="http://www.com">www.com</a></para>
            /// </summary>
            [NameInMap("Dns1")]
            [Validation(Required=false)]
            public string Dns1 { get; set; }

            /// <summary>
            /// <para>The second custom DNS server.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required only if you set <b>AliyunDns</b> to <b>false</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Make sure that your custom DNS servers are valid. Otherwise, the domain reservation may fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nsb.263idc.net</para>
            /// </summary>
            [NameInMap("Dns2")]
            [Validation(Required=false)]
            public string Dns2 { get; set; }

            /// <summary>
            /// <para>The domain name to reserve.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

    }

}
