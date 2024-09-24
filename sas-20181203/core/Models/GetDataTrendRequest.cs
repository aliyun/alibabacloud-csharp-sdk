// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendRequest : TeaModel {
        /// <summary>
        /// <para>The type of the security data that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HC_NEW</b>: the number of new baseline risks.</description></item>
        /// <item><description><b>HC_OPERATE</b>: the number of handled baseline risks.</description></item>
        /// <item><description><b>VUL_NEW</b>: the number of new vulnerabilities.</description></item>
        /// <item><description><b>VUL_OPERATE</b>: the number of handled vulnerabilities.</description></item>
        /// <item><description><b>SUSP_NEW</b>: the number of new alerts.</description></item>
        /// <item><description><b>SUSP_OPERATE</b>: the number of handled alerts.</description></item>
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
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721923200000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The interval of the data that you want to query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> The minimum value is 1000.</para>
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
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
