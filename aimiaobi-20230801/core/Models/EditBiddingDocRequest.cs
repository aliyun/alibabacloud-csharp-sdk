// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class EditBiddingDocRequest : TeaModel {
        /// <summary>
        /// <para>The text content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>标书内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>html
        /// markdown</para>
        /// </summary>
        [NameInMap("ContentFormat")]
        [Validation(Required=false)]
        public string ContentFormat { get; set; }

        /// <summary>
        /// <para>The content type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outline
        /// bidding</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0dbf1055f8a2475d99904c3b76a0ffba</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The workspace ID.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
