// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Resource : TeaModel {
        [NameInMap("elasticResource")]
        [Validation(Required=false)]
        public ResourceSpec ElasticResource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fixedResource")]
        [Validation(Required=false)]
        public ResourceSpec FixedResource { get; set; }

    }

}
