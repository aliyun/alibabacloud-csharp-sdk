// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>A unified request body for managing alert rules with the CREATE, UPDATE, PATCH, and BATCH_DELETE actions. The required fields depend on the specified action.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ManageAlertRulesUnifiedActionInput Body { get; set; }

    }

}
