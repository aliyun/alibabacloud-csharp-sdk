// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveDomainRequest : TeaModel {
        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://demo.aliyundoc.com/status.html">http://demo.aliyundoc.com/status.html</a></para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>The ingest domain or streaming domain that you want to add. Wildcard domain names that start with a period (.) are supported.</para>
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
        /// <item><description><b>liveVideo</b>: streaming domain. This value is required if you set the DomainName parameter to a streaming domain.</description></item>
        /// <item><description><b>liveEdge</b>: ingest domain. This value is required if you set the DomainName parameter to an ingest domain.</description></item>
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
        /// <para>The region in which the domain name resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
        /// <item><description><b>cn-qingdao</b>: China (Qingdao)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
        /// <item><description><b>ap-northeast-1</b>: Japan (Tokyo)</description></item>
        /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta)</description></item>
        /// </list>
        /// <remarks>
        /// <para> Make sure that the settings of the Region and Scope parameters do not conflict with each other.</para>
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
        /// <para>The ID of the resource group. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzw******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The edge group. This parameter is applicable to users of level 3 or higher in mainland China and users outside mainland China. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: mainland China. This is the default value.</description></item>
        /// <item><description><b>overseas</b>: outside mainland China.</description></item>
        /// <item><description><b>global</b>: regions in and outside mainland China.</description></item>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddLiveDomainRequestTag> Tag { get; set; }
        public class AddLiveDomainRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The top-level domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn.aliyundoc.com</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
