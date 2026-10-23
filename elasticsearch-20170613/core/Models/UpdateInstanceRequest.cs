// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client node configuration.</para>
        /// </summary>
        [NameInMap("clientNodeConfiguration")]
        [Validation(Required=false)]
        public ClientNodeConfiguration ClientNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The elastic node configuration.</para>
        /// </summary>
        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The index node configuration. This parameter is supported only by AI engine instances.</para>
        /// </summary>
        [NameInMap("indexNodeConfiguration")]
        [Validation(Required=false)]
        public IndexNodeConfiguration IndexNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The edition type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>x-pack: Commercial Edition.</description></item>
        /// <item><description>advanced: Advanced Edition.</description></item>
        /// <item><description>IS: Advanced Edition with Indexing Service enabled.</description></item>
        /// <item><description>community: Basic Edition.<remarks>
        /// <para>To create an Advanced Edition instance with OpenStore enabled, you must also enable Indexing Service.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("instanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        /// <summary>
        /// <para>The Kibana node configuration.</para>
        /// </summary>
        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        /// <summary>
        /// <para>The dedicated master node configuration.</para>
        /// </summary>
        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        /// <summary>
        /// <para>The data node configuration.</para>
        /// </summary>
        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        /// <summary>
        /// <para>The search node configuration. This parameter is supported only by AI engine instances.</para>
        /// </summary>
        [NameInMap("searchNodeConfiguration")]
        [Validation(Required=false)]
        public SearchNodeConfiguration SearchNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The update type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: In-place update.</description></item>
        /// <item><description>blue_green: Blue-green update.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blue_green</para>
        /// </summary>
        [NameInMap("updateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

        /// <summary>
        /// <para>The warm data node configuration.</para>
        /// </summary>
        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to force a restart. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The configuration change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>upgrade: Upgrades the configuration. This is the default value.</description></item>
        /// <item><description>downgrade: Downgrades the configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>upgrade</para>
        /// </summary>
        [NameInMap("orderActionType")]
        [Validation(Required=false)]
        public string OrderActionType { get; set; }

    }

}
