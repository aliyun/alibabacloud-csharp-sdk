// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The request body for managing alert rules. This body is shared by the CREATE, UPDATE, PATCH, and BATCH_DELETE actions. Specify the fields based on the action.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ManageAlertRulesUnifiedActionInput Body { get; set; }

        /// <summary>
        /// <para>The identifier of the call source, which specifies the internal integration channel to which the caller belongs (such as bailian, integrationCenter, or managed_service_for_prometheus). This parameter is used to isolate traffic from different call sources. You do not need to specify this parameter for regular OpenAPI calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("callSource")]
        [Validation(Required=false)]
        public string CallSource { get; set; }

    }

}
