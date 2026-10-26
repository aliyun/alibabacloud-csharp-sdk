// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DatasourceConfigUnified : TeaModel {
        /// <summary>
        /// <para>The Prometheus instance ID, which is used when the type is PROMETHEUS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The original V1 datasource JSON string returned as a fallback when the type is UNKNOWN and the read path parsing fails. If this field is not empty, the frontend displays it in read-only mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;SLS&quot;}</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>The legacy type returned when the type is UNKNOWN. This indicates that the rule cannot be edited by using the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The namespace of the virtual Prometheus instance. This parameter is optional when the type is VIRTUAL_PROMETHEUS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The category of the Alibaba Cloud service. This parameter is optional when the type is CLOUD_MONITORING. If this information is missing from the source, the value is unknown.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project. This parameter is required when the type is SLS. All stores share the same project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is optional for all types and defaults to the region of the rule or gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of Simple Log Service stores. This parameter is used when the type is SLS and must contain at least one store. Each store includes the store and storeType fields. The project and regionId fields are moved to the top level. The fields with the same names remaining in the stores are deprecated and return a 400 error if used in the write path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;store&quot;:&quot;cms-alert-log&quot;,&quot;storeType&quot;:&quot;log&quot;}]</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<Stores> Stores { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the virtual Prometheus instance belongs. This parameter is optional when the type is VIRTUAL_PROMETHEUS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxxxxxx</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values and corresponding fields: PROMETHEUS (instanceId is required; regionId is optional), VIRTUAL_PROMETHEUS (instanceId is required; regionId, namespace, and tenantId are optional), UMODEL (regionId is optional; other fields are carried in queryConfig or conditionConfig), APM (regionId is optional), XTRACE (regionId is optional), EBPF (regionId is optional), RUM (regionId is optional), CLOUD_MONITORING (regionId and productCategory are optional), SLS (project and stores are required), and UNKNOWN (read-only fallback; do not use in the write path). Non-enum values such as CMS_BASIC_DS or SLS_DS are not allowed and return an Invalidtype 400 error.</para>
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
