// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DatasourceConfigUnified : TeaModel {
        /// <summary>
        /// <para>The Prometheus instance ID. Used when type is set to PROMETHEUS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The raw V1 datasource JSON string returned as a read-path fallback when type is set to UNKNOWN and parsing fails. The frontend displays this field as read-only when the value is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;SLS&quot;}</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>Returned when type is set to UNKNOWN. Indicates that the rule cannot be edited through the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The namespace. Optional when type is set to VIRTUAL_PROMETHEUS. Identifies the namespace to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud service category. Optional when type is set to CLOUD_MONITORING. Returns unknown when the source does not contain this information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The Simple Log Service (SLS) project name. Required when type is set to SLS. All stores share the same project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The region ID. Optional for all types. Defaults to the region of the rule or gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of SLS stores. Used when type is set to SLS. At least one store is required. Each store contains store and storeType fields. The project and regionId fields have been moved to the top level. The deprecated fields with the same names that remain in stores return a 400 error if used in write paths.</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<Stores> Stores { get; set; }

        /// <summary>
        /// <para>The tenant ID. Optional when type is set to VIRTUAL_PROMETHEUS. Identifies the tenant to which the virtual Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-xxxxxxx</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The datasource type.</para>
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
