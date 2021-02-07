// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreateAppEnvRequest : TeaModel {
        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("EnvDescription")]
        [Validation(Required=false)]
        public string EnvDescription { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("PkgVersionId")]
        [Validation(Required=false)]
        public string PkgVersionId { get; set; }

        [NameInMap("OptionSettings")]
        [Validation(Required=false)]
        public string OptionSettings { get; set; }

        [NameInMap("ProfileName")]
        [Validation(Required=false)]
        public string ProfileName { get; set; }

        [NameInMap("SourceEnvId")]
        [Validation(Required=false)]
        public string SourceEnvId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ExtraProperties")]
        [Validation(Required=false)]
        public string ExtraProperties { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
