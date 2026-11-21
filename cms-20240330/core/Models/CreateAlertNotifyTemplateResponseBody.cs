// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAlertNotifyTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the notification template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("alertNotifyTemplateId")]
        [Validation(Required=false)]
        public string AlertNotifyTemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A33DBEA-<em><b><b>-</b></b></em>-<em><b><b>-</b></b></em></para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
