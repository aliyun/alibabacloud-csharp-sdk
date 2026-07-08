// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainRegionDataRequest : TeaModel {
        /// <summary>
        /// <para>Visual Edge Computing Service domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>End time of the data range. The end time must be later than the start time. Specify the time in ISO 8601 format in UTC.<br>Format: YYYY-MM-DDThh:mm:ssZ.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Start time of the data range. Specify the time in ISO 8601 format in UTC.<br>Format: YYYY-MM-DDThh:mm:ssZ.<br>Minimum data granularity is 5 minutes.<br>If you do not specify this parameter, data from the last 24 hours is returned by default.<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
