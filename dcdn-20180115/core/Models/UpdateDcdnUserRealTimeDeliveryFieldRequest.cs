// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnUserRealTimeDeliveryFieldRequest : TeaModel {
        /// <summary>
        /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
        /// 
        /// *   **cdn_log_access_l1**: access logs of L1 Dynamic Route for CDN (DCDN) points of presence (POPs)
        /// *   **cdn_log_origin**: back-to-origin logs
        /// *   **cdn_log_er**: EdgeRoutine logs
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The list of fields. Separate multiple fields with commas (,). For more information, see [Fields in a real-time log](https://help.aliyun.com/document_detail/324199.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

    }

}
