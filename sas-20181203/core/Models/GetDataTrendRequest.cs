// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendRequest : TeaModel {
        /// <summary>
        /// <para>The type of security data to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HC_NEW</b>: number of new baseline risks</description></item>
        /// <item><description><b>HC_OPERATE</b>: number of handled baseline risks</description></item>
        /// <item><description><b>VUL_NEW</b>: number of new vulnerability risks</description></item>
        /// <item><description><b>VUL_OPERATE</b>: number of handled vulnerability risks</description></item>
        /// <item><description><b>SUSP_NEW</b>: number of new alert risks</description></item>
        /// <item><description><b>SUSP_OPERATE</b>: number of handled alert risks.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HC_NEW,HC_OPERATE</para>
        /// </summary>
        [NameInMap("BizTypes")]
        [Validation(Required=false)]
        public string BizTypes { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721923200000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The interval for querying data. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Minimum value: 1000.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687334501000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
