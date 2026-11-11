// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class OpenDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether log delivery is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Log delivery is enabled.</description></item>
        /// <item><description>false: Log delivery failed to be enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FD134E-D69B-51E8-B052-73F97BD8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
