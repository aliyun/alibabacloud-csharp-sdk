// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the logical Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens-sink-bucketzyp1656903494</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time must be in UTC. Format: 2010-01-21T09:50:23Z.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-12T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The aggregation granularity. Unit: minutes.</para>
        /// <para>Default value: 5. Valid values: 5 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time must be in UTC. Format: 2010-01-21T09:50:23Z.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-11T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
