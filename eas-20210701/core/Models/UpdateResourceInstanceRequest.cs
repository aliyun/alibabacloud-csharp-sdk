// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The scheduling behavior to update for the instance in the dedicated resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Uncordon: Allows services to be scheduled to the instance.</para>
        /// </description></item>
        /// <item><description><para>Cordon: Prevents services from being scheduled to the instance.</para>
        /// </description></item>
        /// <item><description><para>Drain: Evicts the service instances that are running on the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cordon</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("NewDiskSize")]
        [Validation(Required=false)]
        public string NewDiskSize { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
