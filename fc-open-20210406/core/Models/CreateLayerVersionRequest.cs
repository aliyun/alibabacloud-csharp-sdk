// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionRequest : TeaModel {
        /// <summary>
        /// The name of the layer.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        /// <summary>
        /// The name of the runtime. Valid values: **nodejs14**, **nodejs12**, **nodejs10**, **nodejs8**, **nodejs6**, **python3.9**, **python3**, **python2.7**, **java11**, **java8**, **php7.2**, **go1**, **dotnetcore2.1** and **custom**.
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// The name of the layer.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
