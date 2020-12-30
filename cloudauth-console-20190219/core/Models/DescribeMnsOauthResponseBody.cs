// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class DescribeMnsOauthResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMnsOauthResponseBodyData Data { get; set; }
        public class DescribeMnsOauthResponseBodyData : TeaModel {
            [NameInMap("TopicList")]
            [Validation(Required=false)]
            public List<string> TopicList { get; set; }
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }
            [NameInMap("MnsAuthorized")]
            [Validation(Required=false)]
            public bool? MnsAuthorized { get; set; }
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }
            [NameInMap("MnsServe")]
            [Validation(Required=false)]
            public bool? MnsServe { get; set; }
            [NameInMap("OpenMnsService")]
            [Validation(Required=false)]
            public bool? OpenMnsService { get; set; }
        };

    }

}
