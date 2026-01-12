// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class BatchCreateSvcMapBindRequest : TeaModel {
        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MapIds")]
        [Validation(Required=false)]
        public List<long?> MapIds { get; set; }

        [NameInMap("SvcId")]
        [Validation(Required=false)]
        public long? SvcId { get; set; }

    }

}
