// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the batch. You can call the <a href="https://help.aliyun.com/document_detail/126617.html">DescribeChangeOrder</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>917660ba-5092-44ca-b8e0-80012c96****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
