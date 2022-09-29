// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateTrainingJobRequest : TeaModel {
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("UserConfig")]
        [Validation(Required=false)]
        public string UserConfig { get; set; }

    }

}
