// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpListEnvInfoResult : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<EnvInfoDO> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>121</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
