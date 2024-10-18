// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateScenegroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AddFriendForbidden")]
        [Validation(Required=false)]
        public long? AddFriendForbidden { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AllMembersCanCreateCalendar")]
        [Validation(Required=false)]
        public long? AllMembersCanCreateCalendar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AllMembersCanCreateMcsConf")]
        [Validation(Required=false)]
        public long? AllMembersCanCreateMcsConf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChatBannedType")]
        [Validation(Required=false)]
        public long? ChatBannedType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GroupEmailDisabled")]
        [Validation(Required=false)]
        public long? GroupEmailDisabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupLiveSwitch")]
        [Validation(Required=false)]
        public long? GroupLiveSwitch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lADOADma*****QKA</para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ManagementType")]
        [Validation(Required=false)]
        public long? ManagementType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MembersToAdminChat")]
        [Validation(Required=false)]
        public long? MembersToAdminChat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MentionAllAuthority")]
        [Validation(Required=false)]
        public long? MentionAllAuthority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnlyAdminCanDing")]
        [Validation(Required=false)]
        public long? OnlyAdminCanDing { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnlyAdminCanSetMsgTop")]
        [Validation(Required=false)]
        public long? OnlyAdminCanSetMsgTop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Searchable")]
        [Validation(Required=false)]
        public long? Searchable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShowHistoryType")]
        [Validation(Required=false)]
        public long? ShowHistoryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>072*****,013*****</para>
        /// </summary>
        [NameInMap("SubadminIds")]
        [Validation(Required=false)]
        public string SubadminIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c354***-<em><b>-</b></em>-b4ea-6f1ab***65</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试群</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>072*****,013*****</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>axcf*-<em><b><b>-</b></b></em>-23da*</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ValidationType")]
        [Validation(Required=false)]
        public long? ValidationType { get; set; }

    }

}
