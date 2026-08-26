// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DatasourceConfigUnified : TeaModel {
        /// <summary>
        /// <para>The Prometheus instance ID. Required when type is PROMETHEUS or VIRTUAL_PROMETHEUS. Ignored for other types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prom-xxxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The raw V1 datasource JSON string returned as a fallback when type is UNKNOWN and read-path parsing fails. When the frontend detects that this field is not empty, display it as read-only.</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>Returned when type is UNKNOWN. Indicates that this rule cannot be edited through the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The namespace. Optional when type is VIRTUAL_PROMETHEUS. Identifies the namespace to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud service category. Optional when type is CLOUD_MONITORING. Returns unknown when the source lacks this information.</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The Simple Log Service (SLS) project name. Required when type is SLS. All stores share the same project.</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The region ID. Optional for PROMETHEUS, VIRTUAL_PROMETHEUS, UMODEL, APM, XTRACE, EBPF, RUM, and SLS types. Defaults to the region of the rule or gateway. Not used for CLOUD_MONITORING. Use AlertRuleV2.regionId instead for CLOUD_MONITORING.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of SLS stores. Used when type is SLS. At least one store is required. Each store contains store and storeType fields. The project and regionId fields have been moved to the top level. The deprecated fields with the same names that remain in stores return a 400 error if used in write paths.</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<Stores> Stores { get; set; }

        /// <summary>
        /// <para>The tenant ID. Optional when type is VIRTUAL_PROMETHEUS. Identifies the tenant to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxxxxxx</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values and associated fields: PROMETHEUS (instanceId required; regionId optional). VIRTUAL_PROMETHEUS (instanceId required; regionId, namespace, and tenantId optional). UMODEL (regionId optional; other fields are carried in queryConfig/conditionConfig). APM (regionId optional). XTRACE (regionId optional). EBPF (regionId optional). RUM (regionId optional). CLOUD_MONITORING (regionId and productCategory optional). SLS (project and stores required). UNKNOWN (read-only fallback; do not use in write paths). Non-enumerated values (such as CMS_BASIC_DS/SLS_DS) are prohibited and the backend returns an Invalidtype 400 error.</para>
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
