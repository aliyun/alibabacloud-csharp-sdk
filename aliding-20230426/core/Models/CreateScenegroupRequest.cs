// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateScenegroupRequest : TeaModel {
        [NameInMap("AddFriendForbidden")]
        [Validation(Required=false)]
        public long? AddFriendForbidden { get; set; }

        [NameInMap("AllMembersCanCreateCalendar")]
        [Validation(Required=false)]
        public long? AllMembersCanCreateCalendar { get; set; }

        [NameInMap("AllMembersCanCreateMcsConf")]
        [Validation(Required=false)]
        public long? AllMembersCanCreateMcsConf { get; set; }

        [NameInMap("ChatBannedType")]
        [Validation(Required=false)]
        public long? ChatBannedType { get; set; }

        [NameInMap("GroupEmailDisabled")]
        [Validation(Required=false)]
        public long? GroupEmailDisabled { get; set; }

        [NameInMap("GroupLiveSwitch")]
        [Validation(Required=false)]
        public long? GroupLiveSwitch { get; set; }

        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("ManagementType")]
        [Validation(Required=false)]
        public long? ManagementType { get; set; }

        [NameInMap("MembersToAdminChat")]
        [Validation(Required=false)]
        public long? MembersToAdminChat { get; set; }

        [NameInMap("MentionAllAuthority")]
        [Validation(Required=false)]
        public long? MentionAllAuthority { get; set; }

        [NameInMap("OnlyAdminCanDing")]
        [Validation(Required=false)]
        public long? OnlyAdminCanDing { get; set; }

        [NameInMap("OnlyAdminCanSetMsgTop")]
        [Validation(Required=false)]
        public long? OnlyAdminCanSetMsgTop { get; set; }

        [NameInMap("Searchable")]
        [Validation(Required=false)]
        public long? Searchable { get; set; }

        [NameInMap("ShowHistoryType")]
        [Validation(Required=false)]
        public long? ShowHistoryType { get; set; }

        [NameInMap("SubadminIds")]
        [Validation(Required=false)]
        public string SubadminIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("ValidationType")]
        [Validation(Required=false)]
        public long? ValidationType { get; set; }

    }

}
