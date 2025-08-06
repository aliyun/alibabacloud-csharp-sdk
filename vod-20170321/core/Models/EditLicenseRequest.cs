// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class EditLicenseRequest : TeaModel {
        [NameInMap("AppItemId")]
        [Validation(Required=false)]
        public string AppItemId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppPlatforms")]
        [Validation(Required=false)]
        public string AppPlatforms { get; set; }

        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SdkModels")]
        [Validation(Required=false)]
        public string SdkModels { get; set; }

    }

}
