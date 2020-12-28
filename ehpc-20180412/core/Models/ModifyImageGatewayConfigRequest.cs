// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyImageGatewayConfigRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBUsername")]
        [Validation(Required=false)]
        public string DBUsername { get; set; }

        [NameInMap("DBPassword")]
        [Validation(Required=false)]
        public string DBPassword { get; set; }

        [NameInMap("DBServerInfo")]
        [Validation(Required=false)]
        public string DBServerInfo { get; set; }

        [NameInMap("DefaultRepoLocation")]
        [Validation(Required=false)]
        public string DefaultRepoLocation { get; set; }

        [NameInMap("PullUpdateTimeout")]
        [Validation(Required=false)]
        public int? PullUpdateTimeout { get; set; }

        [NameInMap("ImageExpirationTimeout")]
        [Validation(Required=false)]
        public string ImageExpirationTimeout { get; set; }

        [NameInMap("Repo")]
        [Validation(Required=false)]
        public List<ModifyImageGatewayConfigRequestRepo> Repo { get; set; }
        public class ModifyImageGatewayConfigRequestRepo : TeaModel {
            [NameInMap("Auth")]
            [Validation(Required=false)]
            public string Auth { get; set; }

            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

    }

}
