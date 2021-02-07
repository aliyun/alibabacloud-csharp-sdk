// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class ValidateConfigSettingRequest : TeaModel {
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("OptionSettings")]
        [Validation(Required=false)]
        public string OptionSettings { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
