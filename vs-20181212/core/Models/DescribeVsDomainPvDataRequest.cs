// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainPvDataRequest : TeaModel {
        /// <summary>
        /// <para>The domain name for Visual Edge Computing Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the \<c>YYYY-MM-DDThh:mm:ssZ\\</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-15T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the \<c>YYYY-MM-DDThh:mm:ssZ\\</c> format. The time must be in UTC.<br>The minimum data granularity is 1 hour.<br>If you do not set this parameter, the data in the last 24 hours is returned.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-10T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
