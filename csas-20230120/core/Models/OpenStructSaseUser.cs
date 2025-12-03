// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class OpenStructSaseUser : TeaModel {
        [NameInMap("CreateTimeUnix")]
        [Validation(Required=false)]
        public long? CreateTimeUnix { get; set; }

        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<IdpCustomField> CustomFields { get; set; }

        [NameInMap("Departments")]
        [Validation(Required=false)]
        public List<OpenStructSaseDepartment> Departments { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

        [NameInMap("LeaveTimeUnix")]
        [Validation(Required=false)]
        public long? LeaveTimeUnix { get; set; }

        [NameInMap("LoginTimeUnix")]
        [Validation(Required=false)]
        public long? LoginTimeUnix { get; set; }

        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        [NameInMap("SaseUserStatus")]
        [Validation(Required=false)]
        public string SaseUserStatus { get; set; }

        [NameInMap("SyncTimeUnix")]
        [Validation(Required=false)]
        public long? SyncTimeUnix { get; set; }

        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UpdateTimeUnix")]
        [Validation(Required=false)]
        public long? UpdateTimeUnix { get; set; }

        [NameInMap("UserTags")]
        [Validation(Required=false)]
        public List<OpenStructSaseUserUserTags> UserTags { get; set; }
        public class OpenStructSaseUserUserTags : TeaModel {
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("WorkStatus")]
        [Validation(Required=false)]
        public string WorkStatus { get; set; }

    }

}
