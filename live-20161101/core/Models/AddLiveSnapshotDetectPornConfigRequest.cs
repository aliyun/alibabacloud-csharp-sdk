// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveSnapshotDetectPornConfigRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=true)]
        public string OssEndpoint { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=true)]
        public string OssBucket { get; set; }

        [NameInMap("OssObject")]
        [Validation(Required=false)]
        public string OssObject { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public List<string> Scene { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

    }

}
