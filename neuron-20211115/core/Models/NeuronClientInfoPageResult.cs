// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronClientInfoPageResult : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<NeuronAppClientInfo> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("showApp")]
        [Validation(Required=false)]
        public bool? ShowApp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
