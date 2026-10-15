// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The aggregated request body for managing alert rules. This body is shared by the CREATE, UPDATE, PATCH, and BATCH_DELETE operations. Specify fields based on the action.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The call source identifier that specifies the internal integration channel of the caller, such as bailian, integrationCenter, or managed_service_for_prometheus. This parameter is used to isolate traffic from different sources. You do not need to specify this parameter for standard OpenAPI calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("callSource")]
        [Validation(Required=false)]
        public string CallSource { get; set; }

    }

}
