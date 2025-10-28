// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ContinuePipelineRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to release the next batch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the next batch.</description></item>
        /// <item><description>false: does not release the next batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Confirm")]
        [Validation(Required=false)]
        public bool? Confirm { get; set; }

        /// <summary>
        /// <para>The ID of the change process. You can call the GetChangeOrderInfo operation to query the ID of the change process that corresponds to a specific batch. For more information, see <a href="https://help.aliyun.com/document_detail/62072.html">GetChangeOrderInfo</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5648dbd7-df13********************</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
