// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsTopDomainsByFlowRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The date format follows the ISO 8601 standard and uses UTC.<br>Format: YYYY-MM-DDThh:mm:ssZ<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of domain names to return. The default value is 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The date format follows the ISO 8601 standard and uses UTC.<br>Format: YYYY-MM-DDThh:mm:ssZ<br>The minimum data granularity is 5 minutes.<br>If you do not specify this parameter, data for the current month is queried.<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-12T10:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
