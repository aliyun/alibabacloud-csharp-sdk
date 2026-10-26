// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceConfig : TeaModel {
        /// <summary>
        /// <para>The UModel entity domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_monitor</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The UModel entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The CloudMonitor namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The CloudMonitor product category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The relation type. TAG is supported only for alert rules where datasourceConfig.type is APM and queryConfig.type is APM_MULTI_QUERY. UMODEL_ENTITY does not support write operations and is used only to read existing data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The resource list. This field can be left empty when relationType is set to ALL, which indicates all resources. When relationType is set to TAG, this field is a list of tags in the key=value format, such as [&quot;env=prod&quot;, &quot;app=foo&quot;]. Only the APM data source and APM_MULTI_QUERY are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp1a2b3c4d5e6f7g8h9i&quot;,&quot;i-bp9h8g7f6e5d4c3b2a1&quot;]</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

    }

}
