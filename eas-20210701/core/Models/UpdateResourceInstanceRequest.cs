// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The operation that updates the scheduling state of the instance in a dedicated resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uncordon: allows scheduling the service to this instance.</description></item>
        /// <item><description>Cordon: prohibits scheduling the service to this instance.</description></item>
        /// <item><description>Drain: evicts the service that has been scheduled to this instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cordon</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
