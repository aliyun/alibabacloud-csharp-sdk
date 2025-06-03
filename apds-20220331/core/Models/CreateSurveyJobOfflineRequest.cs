// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class CreateSurveyJobOfflineRequest : TeaModel {
        [NameInMap("autoConfirm")]
        [Validation(Required=false)]
        public bool? AutoConfirm { get; set; }

        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("cloudType")]
        [Validation(Required=false)]
        public string CloudType { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("objectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
