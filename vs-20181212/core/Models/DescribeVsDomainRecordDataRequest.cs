// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainRecordDataRequest : TeaModel {
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
        /// <para>End time of the data range. Must be later than StartTime. Use ISO 8601 notation in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-19T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Region information</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Start time of the data range. Use ISO 8601 notation in UTC. Format: YYYY-MM-DDThh:mm:ssZ. Minimum data granularity is 5 minutes. If you omit this parameter, the API returns data from the last 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-29T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
