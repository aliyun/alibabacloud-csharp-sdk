// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class App : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("app_name")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("logo")]
        [Validation(Required=false)]
        public string Logo { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public List<string> Scope { get; set; }

        [NameInMap("stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
