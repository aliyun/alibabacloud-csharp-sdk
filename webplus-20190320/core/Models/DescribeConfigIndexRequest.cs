// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeConfigIndexRequest : TeaModel {
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("ProfileName")]
        [Validation(Required=false)]
        public string ProfileName { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
