// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ModifyAppServiceEnvParamsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AppServiceEnvParam")]
        [Validation(Required=false)]
        public List<ModifyAppServiceEnvParamsResponseBodyAppServiceEnvParam> AppServiceEnvParam { get; set; }
        public class ModifyAppServiceEnvParamsResponseBodyAppServiceEnvParam : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppServiceId")]
            [Validation(Required=false)]
            public string AppServiceId { get; set; }

            [NameInMap("BaselineBuildpackId")]
            [Validation(Required=false)]
            public string BaselineBuildpackId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("OriginalDefaultValue")]
            [Validation(Required=false)]
            public string OriginalDefaultValue { get; set; }

            [NameInMap("OriginalDescription")]
            [Validation(Required=false)]
            public string OriginalDescription { get; set; }

            [NameInMap("OriginalReadonly")]
            [Validation(Required=false)]
            public string OriginalReadonly { get; set; }

            [NameInMap("OriginalRequired")]
            [Validation(Required=false)]
            public bool? OriginalRequired { get; set; }

            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
