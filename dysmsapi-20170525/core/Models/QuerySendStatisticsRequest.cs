// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Format: yyyyMMdd. Example: 20181225.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The site from where the message is sent. Valid values:
        /// 
        /// *   **1**: China site
        /// *   **2**: international site
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IsGlobe")]
        [Validation(Required=false)]
        public int? IsGlobe { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1 to 50**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The signature.
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Format: yyyyMMdd. Example: 20181225.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The type of the message template. Valid values: Valid values:
        /// 
        /// *   **0**: verification code
        /// *   **1**: notification
        /// *   **2**: promotional message (Enterprise users only)
        /// *   **3**: international purpose (Enterprise users only)
        /// *   **7**: digital message
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
