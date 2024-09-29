// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class OpenVClusterRequest : TeaModel {
        /// <summary>
        /// <para>The type of the cluster. For cloud services, set this parameter to <c>cloud-product-prometheus</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud-product-prometheus</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The length of the cluster ID. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The name of the cloud service. This parameter must be specified when ClusterType is set to <c>cloud-product-prometheus</c>. Valid values: influxdb, mongodb, and DLA. You cannot specify multiple service names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>influxdb</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>Specifies whether to create or query a virtual cluster. This parameter provides backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecreateSwitch")]
        [Validation(Required=false)]
        public bool? RecreateSwitch { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
