// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateOpenGlobalDataRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppMaxVersion")]
        [Validation(Required=false)]
        public string AppMaxVersion { get; set; }

        [NameInMap("AppMinVersion")]
        [Validation(Required=false)]
        public string AppMinVersion { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ExtAttrStr")]
        [Validation(Required=false)]
        public string ExtAttrStr { get; set; }

        [NameInMap("MaxUid")]
        [Validation(Required=false)]
        public long? MaxUid { get; set; }

        [NameInMap("MinUid")]
        [Validation(Required=false)]
        public long? MinUid { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("ThirdMsgId")]
        [Validation(Required=false)]
        public string ThirdMsgId { get; set; }

        [NameInMap("Uids")]
        [Validation(Required=false)]
        public string Uids { get; set; }

        [NameInMap("ValidTimeEnd")]
        [Validation(Required=false)]
        public long? ValidTimeEnd { get; set; }

        [NameInMap("ValidTimeStart")]
        [Validation(Required=false)]
        public long? ValidTimeStart { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
