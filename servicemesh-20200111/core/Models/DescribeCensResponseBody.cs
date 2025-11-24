// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Kubernetes clusters that are added to the same ASM instance but are in different VPCs and are not connected by using a Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<string> Clusters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
