// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricRequest : TeaModel {
        /// <summary>
        /// The space ID of the RAM user within the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// The granularity of the metric.
        /// 
        /// Valid values:
        /// 
        /// *   DAILY
        /// *   HALF_HOUR
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// The independent software vendor (ISV) verification code, which is used to verify whether the RAM user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The template language.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// The template code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The template type. If you do not specify this parameter, the default value WHATSAPP is used.
        /// 
        /// Valid values:
        /// 
        /// *   VIBER
        /// *   WHATSAPP
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
