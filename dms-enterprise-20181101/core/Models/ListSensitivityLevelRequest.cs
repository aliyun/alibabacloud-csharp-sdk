// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitivityLevelRequest : TeaModel {
        /// <summary>
        /// The ID of the classification template. You can call the [ListClassificationTemplates](~~460613~~) operation to query the ID of the classification template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// The type of the classification template. You can call the [ListClassificationTemplates](~~460613~~) operation to query the type of the classification template.
        /// 
        /// Valid values:
        /// 
        /// *   USER_DEFINE: a custom template.
        /// *   INNER: a built-in template.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [View information about the current tenant](~~181330~~) in the topic "Manage DMS tenants."
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
