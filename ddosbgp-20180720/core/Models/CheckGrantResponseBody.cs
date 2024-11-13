// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CheckGrantResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB002CE5-5E6C-5F11-AE15-B525299A40F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether Anti-DDoS Origin is authorized to obtain information about the assets within the current Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Anti-DDoS Origin is authorized to obtain information about the assets within the current Alibaba Cloud account.</description></item>
        /// <item><description><b>0</b>: Anti-DDoS Origin is not authorized to obtain information about the assets within the current Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
