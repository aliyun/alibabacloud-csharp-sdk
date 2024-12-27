// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListIpOrHostsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583723776974</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the service. If you do not specify this parameter, the IP addresses of all applications in the specified region are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service1</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583683200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
