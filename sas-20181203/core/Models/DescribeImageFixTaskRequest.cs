// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixTaskRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the results to return. Default value: <b>1</b>, which indicates that the results start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end timestamp of the repair task that you want to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635575219000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query. Default value: <b>20</b>, which indicates that up to 20 entries are returned per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start timestamp of the repair task that you want to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634725571000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the image repair task that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Repairing</description></item>
        /// <item><description><b>2</b>: Repaired</description></item>
        /// <item><description><b>3</b>: Repair failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
