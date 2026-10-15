// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryUserOmsDataRequest : TeaModel {
        /// <summary>
        /// <para>The data timestamp type of the metering data. Refer to the specific service documentation for details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Raw: hourly</description></item>
        /// <item><description>Hour: hourly</description></item>
        /// <item><description>Day: daily</description></item>
        /// <item><description>Month: monthly</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The end time of the request.</para>
        /// <para>The date format must comply with the ISO 8601 standard and use UTC time. Format: yyyy-mm-ddThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-21T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The marker that specifies the starting point for returning results in alphabetical order after the NextToken. By default, results are returned from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NextToken</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of rows per page for paging in a paged query. Valid values: 1 to 200. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the request.</para>
        /// <para>The date format must comply with the ISO 8601 standard and use UTC time. Format: yyyy-mm-ddThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-20T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The product and detail information for the usage data, which is typically the ProductCode. Different services support multiple metering models.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
