// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchUpdateApisVpcAccessRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("OldVpcId")]
        [Validation(Required=false)]
        public string OldVpcId { get; set; }

        [NameInMap("OldInstanceId")]
        [Validation(Required=false)]
        public string OldInstanceId { get; set; }

        [NameInMap("OldPort")]
        [Validation(Required=false)]
        public int? OldPort { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DisplayInstanceId")]
        [Validation(Required=false)]
        public string DisplayInstanceId { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("ServiceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchUpdateApisVpcAccessRequestApi> Api { get; set; }
        public class BatchUpdateApisVpcAccessRequestApi : TeaModel {
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("ApiUid")]
            [Validation(Required=false)]
            public string ApiUid { get; set; }

        }

    }

}
