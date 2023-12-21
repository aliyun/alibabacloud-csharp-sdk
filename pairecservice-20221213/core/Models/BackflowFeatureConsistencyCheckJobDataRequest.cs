// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class BackflowFeatureConsistencyCheckJobDataRequest : TeaModel {
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemFeatures")]
        [Validation(Required=false)]
        public string ItemFeatures { get; set; }

        [NameInMap("LogItemId")]
        [Validation(Required=false)]
        public string LogItemId { get; set; }

        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        [NameInMap("LogRequestTime")]
        [Validation(Required=false)]
        public long? LogRequestTime { get; set; }

        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public string LogUserId { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("Scores")]
        [Validation(Required=false)]
        public string Scores { get; set; }

        [NameInMap("UserFeatures")]
        [Validation(Required=false)]
        public string UserFeatures { get; set; }

    }

}
