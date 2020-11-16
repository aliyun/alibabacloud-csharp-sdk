// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartLiveIndexRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=true)]
        public string StreamName { get; set; }

        [NameInMap("TokenId")]
        [Validation(Required=true)]
        public string TokenId { get; set; }

        [NameInMap("InputUrl")]
        [Validation(Required=true)]
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
