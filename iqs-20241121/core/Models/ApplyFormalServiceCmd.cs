// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ApplyFormalServiceCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("accountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("applyServiceInfos")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ApplyServiceInfos { get; set; }

        [NameInMap("applyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        [NameInMap("contactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("qps")]
        [Validation(Required=false)]
        public int? Qps { get; set; }

        [NameInMap("sceneDesc")]
        [Validation(Required=false)]
        public string SceneDesc { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
