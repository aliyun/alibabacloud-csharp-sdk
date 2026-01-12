// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class UpdateLocationServiceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("Qps")]
        [Validation(Required=false)]
        public int? Qps { get; set; }

        [NameInMap("SvcName")]
        [Validation(Required=false)]
        public string SvcName { get; set; }

        [NameInMap("SvcState")]
        [Validation(Required=false)]
        public string SvcState { get; set; }

    }

}
