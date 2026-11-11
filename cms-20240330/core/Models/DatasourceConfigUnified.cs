// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DatasourceConfigUnified : TeaModel {
        /// <summary>
        /// <para>The Prometheus instance ID. This field is used when type is PROMETHEUS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The original V1 datasource JSON string returned as a fallback when type is UNKNOWN and read path parsing fails. The frontend displays this field as read-only when it is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;SLS&quot;}</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>The legacy type, which is returned when type is UNKNOWN to indicate that this rule cannot be edited by using the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The namespace. This field is optional when type is VIRTUAL_PROMETHEUS and identifies the namespace to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The cloud service category. This field is optional when type is CLOUD_MONITORING. Outputs unknown when this information is missing from the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project name. This field is required when type is SLS, and all stores share the same project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The region ID. This field is optional for all types and defaults to the rule or gateway region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service store list. This field is used when type is SLS and requires at least one store. Each store includes store and storeType. The project and regionId fields are moved to the top level. The fields with the same names remaining in Stores are deprecated and return 400 in the write path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;store&quot;:&quot;cms-alert-log&quot;,&quot;storeType&quot;:&quot;log&quot;}]</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<Stores> Stores { get; set; }

        /// <summary>
        /// <para>The tenant ID. This field is optional when type is VIRTUAL_PROMETHEUS and identifies the tenant to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxxxxxx</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
