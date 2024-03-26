// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The protection templates.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeDefenseTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeDefenseTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// The scenario in which the protection template is used.
            /// 
            /// *   **waf_group**: basic protection.
            /// *   **antiscan**: scan protection.
            /// *   **ip_blacklist**: IP address blacklist.
            /// *   **custom_acl**: custom rule.
            /// *   **whitelist**: whitelist.
            /// *   **region_block**: region blacklist.
            /// *   **custom_response**: custom response.
            /// *   **cc**: HTTP flood protection.
            /// *   **tamperproof**: website tamper-proofing.
            /// *   **dlp**: data leakage prevention.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The sub-scenario in which the protection template is used. Valid values:
            /// 
            /// *   **web**: bot management for website protection.
            /// *   **app**: bot management for app protection.
            /// *   **basic**: bot management for basic protection.
            /// </summary>
            [NameInMap("DefenseSubScene")]
            [Validation(Required=false)]
            public string DefenseSubScene { get; set; }

            /// <summary>
            /// The description of the protection template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the protection template was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The ID of the protection template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// The name of the protection template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The origin of the protection template. The value custom indicates that the protection template is a custom template created by the user.
            /// </summary>
            [NameInMap("TemplateOrigin")]
            [Validation(Required=false)]
            public string TemplateOrigin { get; set; }

            /// <summary>
            /// The status of the protection template. Valid values:
            /// 
            /// *   **0**: disabled.
            /// *   **1**: enabled.
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

            /// <summary>
            /// The type of the protection template. Valid values:
            /// 
            /// *   **user_default**: default template.
            /// *   **user_custom**: custom template.
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
