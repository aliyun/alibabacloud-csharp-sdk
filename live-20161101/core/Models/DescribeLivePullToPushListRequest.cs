// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullToPushListRequest : TeaModel {
        /// <summary>
        /// <para>The destination URL. Fuzzy search is performed based on the destination URL.</para>
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
        /// <para> The value must be greater than 0 and not greater than the maximum value of the Integer data type. Default value: 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para> Valid values: [1,100]. Default value: 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the live center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// <item><description>ap-southeast-5: Indonesia (Jakarta)</description></item>
        /// <item><description>cn-beijing: China (Beijing)</description></item>
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The task ID. Fuzzy search is performed based on the task ID.</para>
        /// <remarks>
        /// <para> The ID can be up to 55 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
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
