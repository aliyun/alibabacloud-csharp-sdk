// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveDomainRequest : TeaModel {
        /// <summary>
        /// <para>The health check URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/status.html">http://demo.aliyundoc.com/status.html</a></para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>The ingest domain or streaming domain to be connected to ApsaraVideo Live. Wildcard domain names are supported and must start with a period (.).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>liveVideo</b>: streaming domain. If you set DomainName (the domain name to be connected to ApsaraVideo Live) to a streaming domain, you must set this parameter to liveVideo.</description></item>
        /// <item><description><b>liveEdge</b>: edge ingest domain. If you set DomainName (the domain name to be connected to ApsaraVideo Live) to an ingest domain, you must set this parameter to liveEdge.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveVideo</para>
        /// </summary>
        [NameInMap("LiveDomainType")]
        [Validation(Required=false)]
        public string LiveDomainType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit information of the live streaming domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: Beijing.</description></item>
        /// <item><description><b>cn-shanghai</b>: Shanghai.</description></item>
        /// <item><description><b>cn-shenzhen</b>: Shenzhen.</description></item>
        /// <item><description><b>cn-qingdao</b>: Qingdao.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// <item><description><b>eu-central-1</b>: Germany.</description></item>
        /// <item><description><b>ap-northeast-1</b>: Tokyo.</description></item>
        /// <item><description><b>ap-southeast-5</b>: Jakarta.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Region (unit information of the live streaming domain name) and Scope (acceleration region) do not restrict each other.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzw******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The acceleration region. This parameter takes effect for international users and China site users at L3 or above. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b> (default): the Chinese mainland.</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China).</description></item>
        /// <item><description><b>global</b>: global acceleration.</description></item>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddLiveDomainRequestTag> Tag { get; set; }
        public class AddLiveDomainRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The top-level domain name for access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn.aliyundoc.com</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
