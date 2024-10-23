// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class FunctionLayer : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-beijing:186824xxxxxx:layers/fc_layer/versions/1</para>
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>421</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
