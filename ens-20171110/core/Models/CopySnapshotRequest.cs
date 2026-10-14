// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The list of destination edge zone IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        /// <summary>
        /// <para>The description of the snapshot. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("DestinationSnapshotDescription")]
        [Validation(Required=false)]
        public string DestinationSnapshotDescription { get; set; }

        /// <summary>
        /// <para>The display name of the snapshot. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("DestinationSnapshotName")]
        [Validation(Required=false)]
        public string DestinationSnapshotName { get; set; }

        /// <summary>
        /// <para>The billing cycle of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour</description></item>
        /// <item><description>Day</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the source snapshot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp1c0doj0taqyzzl****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
