// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class AddDcdnDomainRequest : TeaModel {
        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>The domain name that you want to add. You can specify only one domain name in each request.</para>
        /// <para>Wildcard domain names are supported. A wildcard domain name must start with a period (.), such as .example.com.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Computing service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>routine</b></description></item>
        /// <item><description><b>image</b></description></item>
        /// <item><description><b>cloudFunction</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>routine</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you do not specify a value for this parameter, the system automatically assigns the ID of the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyuji4b6r4**</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Acceleration scen. Supported:</para>
        /// <list type="bullet">
        /// <item><description>apiscene:API acceleration.</description></item>
        /// <item><description>webservicescene: accelerate website business.</description></item>
        /// <item><description>staticscene: video and graphic acceleration.</description></item>
        /// <item><description>(Empty): no scene.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apiscene</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// </list>
        /// <para>Default value: <b>domestic</b>.</para>
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
        /// <para>The information about the addresses of origin servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;content&quot;:&quot;10.10.10.10&quot;,&quot;type&quot;:&quot;ipaddr&quot;,&quot;priority&quot;:&quot;20&quot;,&quot;port&quot;:80}]</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddDcdnDomainRequestTag> Tag { get; set; }
        public class AddDcdnDomainRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of a tag. Valid values of N: <b>1 to 20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of a tag. Valid values of N: <b>1 to 20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The top-level domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTopLevelDomain</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
