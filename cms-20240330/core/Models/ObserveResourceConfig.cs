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
        /// <para>The relation type. TAG is supported only for alert rules where datasourceConfig.type is set to APM and queryConfig.type is set to APM_MULTI_QUERY. UMODEL_ENTITY does not support writes and is used only for reading existing data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The list of resources. If relationType is set to ALL, this parameter can be left empty, which indicates all resources. If relationType is set to TAG, this parameter is a list of labels in key=value format (such as [&quot;env=prod&quot;, &quot;app=foo&quot;]). This is supported only for APM data sources with APM_MULTI_QUERY.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

    }

}
