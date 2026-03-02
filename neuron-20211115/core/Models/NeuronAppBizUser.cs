// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class NeuronAppBizUser : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1235254534</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>233131</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADMIN</para>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

    }

}
