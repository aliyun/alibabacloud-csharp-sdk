// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// The ID of the animated image template.
        /// </summary>
        [NameInMap("DynamicImageTemplateId")]
        [Validation(Required=false)]
        public string DynamicImageTemplateId { get; set; }

        /// <summary>
        /// The ID of the animated image job.
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
