// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnReportRequest : TeaModel {
        /// <summary>
        /// <para>The region. You can call the <a href="https://help.aliyun.com/document_detail/207199.html">DescribeDcdnRegionAndIsp</a> operation to query regions.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify a region, data in all regions is queried.</description></item>
        /// <item><description>If you specify a region, data in the specified region is returned. You can specify one or more regions. Separate regions with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The domain names that you want to query. Separate domain names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com,www.example.org">www.example.com,www.example.org</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-02T01:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: HTTP 2xx status codes</description></item>
        /// <item><description><b>3xx</b>: HTTP 3xx status codes</description></item>
        /// <item><description><b>4xx</b>: HTTP 4xx status codes</description></item>
        /// <item><description><b>5xx</b>: HTTP 5xx status codes</description></item>
        /// </list>
        /// <para>If you do not specify an HTTP status code, data for all preceding HTTP status codes is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xx</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>Specify whether the region is outside the Chinese mainland. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>0</b>: inside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsOverseas")]
        [Validation(Required=false)]
        public string IsOverseas { get; set; }

        /// <summary>
        /// <para>The ID of the operations report that you want to query. You can enter only one ID in each call. You can call the <a href="https://help.aliyun.com/document_detail/270075.html">DescribeDcdnSubList</a> operation to query report IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
