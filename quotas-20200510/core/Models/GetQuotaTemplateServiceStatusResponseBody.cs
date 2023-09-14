// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaTemplateServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the quota template.
        /// </summary>
        [NameInMap("TemplateServiceStatus")]
        [Validation(Required=false)]
        public GetQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus TemplateServiceStatus { get; set; }
        public class GetQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus : TeaModel {
            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The state of the quota template. Valid values:
            /// 
            /// *   \-1: The quota template is disabled.
            /// *   1: The quota template is enabled.
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

        }

    }

}
