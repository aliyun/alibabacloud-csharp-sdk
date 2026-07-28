// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProviderDocumentRequest : TeaModel {
        [NameInMap("providerVersion")]
        [Validation(Required=false)]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
