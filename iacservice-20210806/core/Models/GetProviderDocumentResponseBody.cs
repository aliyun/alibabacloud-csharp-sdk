// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProviderDocumentResponseBody : TeaModel {
        [NameInMap("document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        [NameInMap("providerVersion")]
        [Validation(Required=false)]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
