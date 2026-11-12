// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Updates the schedulable behavior of the machine instance in the dedicated resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uncordon: Allows services to be scheduled to this instance.</description></item>
        /// <item><description>Cordon: Prevents services from being scheduled to this instance.</description></item>
        /// <item><description>Drain: Evicts service instances that are already scheduled to this instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cordon</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk after scaling, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("NewDiskSize")]
        [Validation(Required=false)]
        public string NewDiskSize { get; set; }

        /// <summary>
        /// <para>Takes effect when Action is set to Cordon or Drain. Records the reason for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node maintenance</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
