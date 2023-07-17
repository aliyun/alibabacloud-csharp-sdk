// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class SearchAlertContactGroupResponseBody : TeaModel {
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public List<SearchAlertContactGroupResponseBodyContactGroups> ContactGroups { get; set; }
        public class SearchAlertContactGroupResponseBodyContactGroups : TeaModel {
            [NameInMap("ContactGroupId")]
            [Validation(Required=false)]
            public long? ContactGroupId { get; set; }

            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<SearchAlertContactGroupResponseBodyContactGroupsContacts> Contacts { get; set; }
            public class SearchAlertContactGroupResponseBodyContactGroupsContacts : TeaModel {
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public long? ContactId { get; set; }

                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("SystemNoc")]
                [Validation(Required=false)]
                public bool? SystemNoc { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
