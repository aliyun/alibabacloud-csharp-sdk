// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID for renewal.</para>
        /// <para>Only upfront instances whose InstanceResourceType is set to EnsInstance are supported. Pay-as-you-go instances cannot be renewed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-56789acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The renewal period of the subscription instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

    }

}
