// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateReportRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The array of message templates.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateCodes")]
        [Validation(Required=false)]
        public List<string> TemplateCodes { get; set; }

    }

}
