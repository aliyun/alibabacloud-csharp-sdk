// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class SetAccessPermissionByApisRequest : TeaModel {
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("AuthValidTime")]
        [Validation(Required=false)]
        public string AuthValidTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
