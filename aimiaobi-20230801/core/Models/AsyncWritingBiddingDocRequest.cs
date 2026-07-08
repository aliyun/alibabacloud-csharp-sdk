// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncWritingBiddingDocRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bidding company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comany name</para>
        /// </summary>
        [NameInMap("CompanyKeyword")]
        [Validation(Required=false)]
        public string CompanyKeyword { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义观点的输入Prompt</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The unique ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AA2AE16-D873-5C5F-9708-15396C382EB1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The ID of the workspace.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
