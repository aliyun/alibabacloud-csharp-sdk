// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrepayBillTotalRequest : TeaModel {
        /// <summary>
        /// <para>The bill type of the user. This parameter is required in practice. An error is returned if this parameter is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>elastic_traffic: elastic traffic</description></item>
        /// <item><description>sdl: sensitive data leak detection traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sdl</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>The page number in a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time. Specify a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>Because billing data is aggregated at the daily granularity, the timestamp must correspond to 00:00:00 of the day in CST (UTC+8). If the timestamp is not aligned to the start of the day, no data may be returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646063922</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language. Enumerated value.
        /// Default value: zh.
        /// Valid value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify a UNIX timestamp in seconds.</para>
        /// <remarks>
        /// <para>Because billing data is aggregated at the daily granularity, the timestamp must correspond to 00:00:00 of the day in CST (UTC+8). If the timestamp is not aligned to the start of the day, no data may be returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656750960</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
