// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AttachDdosToAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance with which the Anti-DDoS Pro/Premium instance is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("DdosConfigList")]
        [Validation(Required=false)]
        public List<AttachDdosToAcceleratorRequestDdosConfigList> DdosConfigList { get; set; }
        public class AttachDdosToAcceleratorRequestDdosConfigList : TeaModel {
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            [NameInMap("DdosRegionId")]
            [Validation(Required=false)]
            public string DdosRegionId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro/Premium instance to be associated with the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-zz11vq7j****</para>
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region where the Anti-DDoS Pro/Premium instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: regions in the Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: regions outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosRegionId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
