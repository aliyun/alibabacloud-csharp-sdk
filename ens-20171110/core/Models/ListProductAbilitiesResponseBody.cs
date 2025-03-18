// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListProductAbilitiesResponseBody : TeaModel {
        [NameInMap("ProductAbilities")]
        [Validation(Required=false)]
        public List<string> ProductAbilities { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
