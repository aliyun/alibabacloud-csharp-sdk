// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class UpdateCapabilityRequest : TeaModel {
        /// <summary>
        /// <para>The configuration description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("itemDesc")]
        [Validation(Required=false)]
        public string ItemDesc { get; set; }

        /// <summary>
        /// <para>The configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;name&quot;: &quot;知识库名称&quot;,
        ///         &quot;type&quot;: &quot;aliyun-es&quot;,
        ///         &quot;endpoint&quot;: {
        ///             &quot;address&quot;: &quot;<a href="http://xxxxx.es-serverless.aliyuncs.com:9200">http://xxxxx.es-serverless.aliyuncs.com:9200</a>&quot;,
        ///             &quot;authorization&quot;: &quot;xxx:ABCDxxxx&quot;,
        ///             &quot;network&quot;: {
        ///                 &quot;type&quot;: &quot;public&quot;
        ///             },
        ///             &quot;region&quot;: &quot;&quot;
        ///         },
        ///         &quot;function&quot;: {
        ///             &quot;indexName&quot;: &quot;product_info&quot;,
        ///             &quot;queryType&quot;: &quot;hybrid-search&quot;,
        ///             &quot;description&quot;: &quot;金融理财产品知识库，理财产品名称列表及详细描述&quot;,
        ///             &quot;parameters&quot;: {
        ///                 &quot;properties&quot;: {
        ///                     &quot;query&quot;: {
        ///                         &quot;defaultValue&quot;: &quot;&quot;,
        ///                         &quot;description&quot;: &quot;理财产品名称或详细描述&quot;,
        ///                         &quot;type&quot;: &quot;string&quot;
        ///                     }
        ///                 },
        ///                 &quot;required&quot;: [
        ///                     &quot;query&quot;
        ///                 ]
        ///             },
        ///             &quot;template&quot;: &quot;{\&quot;query\&quot;:{\&quot;multi_match\&quot;:{\&quot;query\&quot;:\&quot;${parameters.query}\&quot;,\&quot;fields\&quot;: [\&quot;*\&quot;]}}}&quot;,
        ///             &quot;type&quot;: &quot;dsl&quot;,
        ///             &quot;embedding&quot;: {
        ///                 &quot;denseModel&quot;: &quot;dense&quot;,
        ///                 &quot;sparseModel&quot;: &quot;sparse&quot;,
        ///                 &quot;address&quot;: &quot;address&quot;,
        ///                 &quot;authorization&quot;: &quot;authorization&quot;
        ///             },
        ///             &quot;filter&quot;: &quot;es或os语句&quot;,
        ///             &quot;size&quot;: 10
        ///         }
        ///     }</para>
        /// </summary>
        [NameInMap("itemValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> ItemValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to validate the request parameters without applying the changes. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
