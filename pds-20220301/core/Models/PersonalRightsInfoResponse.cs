// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class PersonalRightsInfoResponse : TeaModel {
        [NameInMap("expires_time")]
        [Validation(Required=false)]
        public string ExpiresTime { get; set; }

        [NameInMap("history_latest_rights")]
        [Validation(Required=false)]
        public PersonalRightsInfoResponse HistoryLatestRights { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("is_expires")]
        [Validation(Required=false)]
        public bool? IsExpires { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("other_rights")]
        [Validation(Required=false)]
        public PersonalRightsInfoResponse OtherRights { get; set; }

        [NameInMap("privileges")]
        [Validation(Required=false)]
        public List<DataBoxPrivileges> Privileges { get; set; }

        [NameInMap("spu_id")]
        [Validation(Required=false)]
        public string SpuId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
