// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricRequest : TeaModel {
        /// <summary>
        /// The space ID of the user within the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// Metric granularity. Valid values:
        /// 
        /// - DAILY
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// The independent software vendor (ISV) verification code. This parameter is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// The code of the message template.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The type of the message template. Valid values:
        /// 
        /// *   **WHATSAPP**
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
