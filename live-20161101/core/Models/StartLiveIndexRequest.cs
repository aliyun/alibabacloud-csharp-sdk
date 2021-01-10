// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartLiveIndexRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("TokenId")]
        [Validation(Required=false)]
        public string TokenId { get; set; }

        [NameInMap("InputUrl")]
        [Validation(Required=false)]
        public string InputUrl { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("OssUserId")]
        [Validation(Required=false)]
        public string OssUserId { get; set; }

        [NameInMap("OssRamRole")]
        [Validation(Required=false)]
        public string OssRamRole { get; set; }

    }

}
