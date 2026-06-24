// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnoseReportRequest : TeaModel {
        /// <summary>
        /// <para>The language of the intelligent diagnostic report. Default value: the browser language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Simplified Chinese</description></item>
        /// <item><description>zt: Traditional Chinese</description></item>
        /// <item><description>es: Spanish</description></item>
        /// <item><description>fr: French</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
