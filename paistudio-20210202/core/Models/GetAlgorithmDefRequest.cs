// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetAlgorithmDefRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("AlgoVersion")]
        [Validation(Required=false)]
        public string AlgoVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logisticregression_binary</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5vqe4Sgtzw8E6opyK3HkK+nzYlY=</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
