// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class RelatedSlsLogStoreRequest : TeaModel {
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("aliyunUserId")]
        [Validation(Required=false)]
        public string AliyunUserId { get; set; }

        [NameInMap("codeupProjectId")]
        [Validation(Required=false)]
        public long? CodeupProjectId { get; set; }

        [NameInMap("defaultViewer")]
        [Validation(Required=false)]
        public bool? DefaultViewer { get; set; }

        [NameInMap("slsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

    }

}
