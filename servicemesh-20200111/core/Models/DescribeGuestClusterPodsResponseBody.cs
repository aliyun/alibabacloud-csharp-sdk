// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterPodsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the names of the queried pods.</para>
        /// </summary>
        [NameInMap("PodList")]
        [Validation(Required=false)]
        public List<string> PodList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDDC0D86-2FC3-56FB-9213-96EB0A3523F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
