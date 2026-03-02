// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ServerInstanceResult : TeaModel {
        [NameInMap("intTotal")]
        [Validation(Required=false)]
        public int? IntTotal { get; set; }

        [NameInMap("ips")]
        [Validation(Required=false)]
        public List<string> Ips { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
