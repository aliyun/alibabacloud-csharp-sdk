// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrepayBillTotalRequest : TeaModel {
        /// <summary>
        /// <para>The bill type. This parameter is required. If it is not specified, an error is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>elastic_traffic: elastic traffic.</description></item>
        /// <item><description>sdl: sensitive data leak detection traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sdl</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>The page number for paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time. Use a UNIX timestamp accurate to seconds.</para>
        /// <remarks>
        /// <para>Because billing data is aggregated on a daily basis, this timestamp must correspond to 00:00:00 of the day in the CST (UTC+8) time zone. If the time is not aligned with midnight, no data may be returned.</para>
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
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh</description></item>
        /// <item><description>en
        /// Default value: zh.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. Use a UNIX timestamp accurate to seconds.</para>
        /// <remarks>
        /// <para>Because billing data is aggregated on a daily basis, this timestamp must correspond to 00:00:00 of the day in the CST (UTC+8) time zone. If the time is not aligned with midnight, no data may be returned.</para>
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
