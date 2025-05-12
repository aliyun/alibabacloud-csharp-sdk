// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The traffic mode. Valid values: auto and customized. auto: The traffic is automatically allocated based on the proportion of the number of instances to the total number of instances. customized: The traffic is allocated based on a custom weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("TrafficMode")]
        [Validation(Required=false)]
        public string TrafficMode { get; set; }

    }

}
