// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetScenegroupResponseBody : TeaModel {
        [NameInMap("groupUrl")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("managementOptions")]
        [Validation(Required=false)]
        public GetScenegroupResponseBodyManagementOptions ManagementOptions { get; set; }
        public class GetScenegroupResponseBodyManagementOptions : TeaModel {
            [NameInMap("ChatBannedType")]
            [Validation(Required=false)]
            public string ChatBannedType { get; set; }

            [NameInMap("ManagementType")]
            [Validation(Required=false)]
            public string ManagementType { get; set; }

            [NameInMap("MentionAllAuthority")]
            [Validation(Required=false)]
            public string MentionAllAuthority { get; set; }

            [NameInMap("Searchable")]
            [Validation(Required=false)]
            public string Searchable { get; set; }

            [NameInMap("ShowHistoryType")]
            [Validation(Required=false)]
            public string ShowHistoryType { get; set; }

            [NameInMap("ValidationType")]
            [Validation(Required=false)]
            public string ValidationType { get; set; }

        }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("ownerStaffId")]
        [Validation(Required=false)]
        public string OwnerStaffId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("subAdminStaffIds")]
        [Validation(Required=false)]
        public List<string> SubAdminStaffIds { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
