// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListProductAbilitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>Products supported by the edge node.</para>
        /// </summary>
        [NameInMap("ProductAbilities")]
        [Validation(Required=false)]
        public List<string> ProductAbilities { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
