// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveLazyPullStreamConfigResponseBody : TeaModel {
        [NameInMap("LiveLazyPullConfigList")]
        [Validation(Required=false)]
        public DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList LiveLazyPullConfigList { get; set; }
        public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList : TeaModel {
            [NameInMap("LiveLazyPullConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig> LiveLazyPullConfig { get; set; }
            public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("PullAppName")]
                [Validation(Required=false)]
                public string PullAppName { get; set; }

                [NameInMap("PullDomainName")]
                [Validation(Required=false)]
                public string PullDomainName { get; set; }

                [NameInMap("PullProtocol")]
                [Validation(Required=false)]
                public string PullProtocol { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
