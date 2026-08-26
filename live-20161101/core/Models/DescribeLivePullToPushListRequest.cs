// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullToPushListRequest : TeaModel {
        /// <summary>
        /// <para>The destination ingest URL. Fuzzy search is performed based on the destination ingest URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://qd</para>
        /// </summary>
        [NameInMap("DstUrl")]
        [Validation(Required=false)]
        public string DstUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>The value of this parameter must be greater than 0 and cannot exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// <remarks>
        /// <para>Default value: 10. Valid values: 1 to 100.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The live center to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ap-southeast-1 (Singapore)</description></item>
        /// <item><description>ap-southeast-5 (Indonesia)</description></item>
        /// <item><description>cn-beijing (Beijing)</description></item>
        /// <item><description>cn-shanghai (Shanghai)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The task ID. Fuzzy search is performed based on the task ID.</para>
        /// <remarks>
        /// <para>The task ID consists of uppercase and lowercase letters, digits, underscores (_), and hyphens (-), with a maximum of 55 characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>861009</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task name. Fuzzy search is performed based on the task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
