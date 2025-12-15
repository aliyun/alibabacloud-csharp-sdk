// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairKVCacheVNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Tair VNode instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tv-2zeb1ce76fee****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the VNode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vn-03a49876edb****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20905403119****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BE6E619-A657-42E3-AD2D-18F8428A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the VCluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vc-16965a9267*****-*****</para>
        /// </summary>
        [NameInMap("VClusterId")]
        [Validation(Required=false)]
        public string VClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the VCluster instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tk-2ze4bba3c8fe****</para>
        /// </summary>
        [NameInMap("VkName")]
        [Validation(Required=false)]
        public string VkName { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
