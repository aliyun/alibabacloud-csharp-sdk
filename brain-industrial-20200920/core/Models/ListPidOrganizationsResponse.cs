// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidOrganizationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("OrganizationList")]
        [Validation(Required=true)]
        public List<ListPidOrganizationsResponseOrganizationList> OrganizationList { get; set; }
        public class ListPidOrganizationsResponseOrganizationList : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=true)]
            public string OrganizationId { get; set; }

            [NameInMap("OrganizationName")]
            [Validation(Required=true)]
            public string OrganizationName { get; set; }

            [NameInMap("OrganizationLevel")]
            [Validation(Required=true)]
            public int? OrganizationLevel { get; set; }

            [NameInMap("ParentOrganizationId")]
            [Validation(Required=true)]
            public string ParentOrganizationId { get; set; }

            [NameInMap("LevelName")]
            [Validation(Required=true)]
            public string LevelName { get; set; }

        }

    }

}
