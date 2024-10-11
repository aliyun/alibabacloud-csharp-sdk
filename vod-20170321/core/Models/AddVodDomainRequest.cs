// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodDomainRequest : TeaModel {
        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/test.html">www.example.com/test.html</a></para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>The domain name that you want to accelerate. Wildcard domain names that start with periods (.) are supported. Example: .example.com.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is applicable to users of level 3 or higher in the Chinese mainland and users outside the Chinese mainland. Default value: domestic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>global</b>: regions in and outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The information about the addresses of origin servers. For more information, see the <b>Sources</b> table in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;content&quot;:&quot;1.1.1.1&quot;,&quot;type&quot;:&quot;ipaddr&quot;,&quot;priority&quot;:&quot;20&quot;,&quot;port&quot;:80}]</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// <para>The top-level domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
