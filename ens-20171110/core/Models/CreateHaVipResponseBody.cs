// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateHaVipResponseBody : TeaModel {
        [NameInMap("HaVipIds")]
        [Validation(Required=false)]
        public List<string> HaVipIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
