// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateReportRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-11 00:00:01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-10 00:00:01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The array of message templates.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateCodes")]
        [Validation(Required=false)]
        public List<string> TemplateCodes { get; set; }

    }

}
