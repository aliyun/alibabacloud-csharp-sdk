// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingTasksRequest : TeaModel {
        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The service to which the destination data source belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute.</description></item>
        /// <item><description><b>2</b>: OSS.</description></item>
        /// <item><description><b>3</b>: ADS.</description></item>
        /// <item><description><b>4</b>: OTS.</description></item>
        /// <item><description><b>5</b>: RDS.</description></item>
        /// <item><description><b>6</b>: SELF_DB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DstType")]
        [Validation(Required=false)]
        public int? DstType { get; set; }

        /// <summary>
        /// <para>The end time of the task creation period. Format: timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583856000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword used to search for tasks. You can search by task name or task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The start time of the task creation period. Format: timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
