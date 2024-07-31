// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DataDesensPlanTemplateValue : TeaModel {
        /// <summary>
        /// The name of the data masking method.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether a watermark is added. Valid values:
        /// 
        /// *   true: allow
        /// *   false: disallow
        /// </summary>
        [NameInMap("SupportWaterMark")]
        [Validation(Required=false)]
        public bool? SupportWaterMark { get; set; }

        /// <summary>
        /// The data masking parameters and their descriptions.
        /// </summary>
        [NameInMap("ExtParamTemplate")]
        [Validation(Required=false)]
        public List<object> ExtParamTemplate { get; set; }

    }

}
