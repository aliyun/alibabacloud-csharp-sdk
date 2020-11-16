// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveLazyPullStreamConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveLazyPullConfigList")]
        [Validation(Required=true)]
        public DescribeLiveLazyPullStreamConfigResponseLiveLazyPullConfigList LiveLazyPullConfigList { get; set; }
        public class DescribeLiveLazyPullStreamConfigResponseLiveLazyPullConfigList : TeaModel {
            [NameInMap("LiveLazyPullConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveLazyPullStreamConfigResponseLiveLazyPullConfigListLiveLazyPullConfig> LiveLazyPullConfig { get; set; }
            public class DescribeLiveLazyPullStreamConfigResponseLiveLazyPullConfigListLiveLazyPullConfig : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string PullDomainName { get; set; }
                public string PullAppName { get; set; }
                public string PullProtocol { get; set; }
                public string PullAuthType { get; set; }
                public string PullAuthKey { get; set; }
                public string PullArgs { get; set; }
            }
        };

    }

}
