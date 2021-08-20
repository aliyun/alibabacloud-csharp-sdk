// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListMergeRequestsRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        [NameInMap("ProjectIdList")]
        [Validation(Required=false)]
        public string ProjectIdList { get; set; }

        [NameInMap("AuthorCodeupIdList")]
        [Validation(Required=false)]
        public string AuthorCodeupIdList { get; set; }

        [NameInMap("AuthorIdList")]
        [Validation(Required=false)]
        public string AuthorIdList { get; set; }

        [NameInMap("AssigneeCodeupIdList")]
        [Validation(Required=false)]
        public string AssigneeCodeupIdList { get; set; }

        [NameInMap("AssigneeIdList")]
        [Validation(Required=false)]
        public string AssigneeIdList { get; set; }

        [NameInMap("SubscriberCodeupIdList")]
        [Validation(Required=false)]
        public string SubscriberCodeupIdList { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("AfterDate")]
        [Validation(Required=false)]
        public string AfterDate { get; set; }

        [NameInMap("BeforeDate")]
        [Validation(Required=false)]
        public string BeforeDate { get; set; }

    }

}
