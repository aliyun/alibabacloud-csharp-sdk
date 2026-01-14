// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateIpSetsRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration regions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<UpdateIpSetsRequestIpSets> IpSets { get; set; }
        public class UpdateIpSetsRequestIpSets : TeaModel {
            /// <summary>
            /// <para>The new bandwidth that you want to allocate to the acceleration regions. Unit: Mbit/s.</para>
            /// <para>You must allocate at least 2 Mbit/s of bandwidth to each acceleration region. You can specify the bandwidth for up to 100 acceleration regions.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The IDs of the acceleration regions that you want to modify.</para>
            /// <para>You can specify the IDs of up to 100 acceleration regions.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ips-bp11c9mpphtb1xkds****</para>
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
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
