// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTaskByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task that you want to query. The following signature algorithms require different message digest algorithms:</para>
        /// <list type="bullet">
        /// <item><description>Perform the <a href="https://help.aliyun.com/document_detail/130620.html">RefreshDcdnObjectCaches</a> operation to query refresh task IDs.</description></item>
        /// <item><description>Perform the <a href="https://help.aliyun.com/document_detail/130636.html">PreloadDcdnObjectCaches</a> operation to query prefetch task IDs.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify at most 10 task IDs in each call. Separate IDs with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113681**</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
