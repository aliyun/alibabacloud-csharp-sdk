// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnSubTaskRequest : TeaModel {
        /// <summary>
        /// <para>The domain names that you want to include in the operations report. If you do not specify a domain name, all domain names that belong to your Alibaba Cloud account are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the operations report. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-17T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The IDs of the metrics that you want to update. Separate IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/270075.html">DescribeDcdnSubList</a> operation to query the IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2,4,6</para>
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

        /// <summary>
        /// <para>The start time of the operations report. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-17T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
