// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePrePaidInstanceStockResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of resources that you can purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84</para>
        /// </summary>
        [NameInMap("AvaliableCount")]
        [Validation(Required=false)]
        public int? AvaliableCount { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The size of the data disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-suzhou-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The specification of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.sn1.stiny</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>007833C8-E819-4122-B636-0D48D7BF6DFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The reason why resources are insufficient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StockNotEnough</para>
        /// </summary>
        [NameInMap("ResourceGap")]
        [Validation(Required=false)]
        public string ResourceGap { get; set; }

        /// <summary>
        /// <para>The size of the system disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

    }

}
