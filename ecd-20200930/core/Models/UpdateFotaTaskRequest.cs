// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UpdateFotaTaskRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the image update task. You can call the <a href="https://help.aliyun.com/document_detail/437001.html">DescribeFotaTasks</a> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aot-c4khwrp9ocml4****</para>
        /// </summary>
        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public string TaskUid { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically push the image update task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: automatically pushes the image update task.</description></item>
        /// <item><description>Pending: does not automatically push the image update task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}
