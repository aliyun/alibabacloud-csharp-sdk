// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-11 00:00:01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The start time. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-10 00:00:01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The card SMS object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateCodes")]
        [Validation(Required=false)]
        public List<string> TemplateCodes { get; set; }

    }

}
