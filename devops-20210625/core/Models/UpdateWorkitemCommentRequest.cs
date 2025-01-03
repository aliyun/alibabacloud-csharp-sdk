// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkitemCommentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1964584</para>
        /// </summary>
        [NameInMap("commentId")]
        [Validation(Required=false)]
        public long? CommentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKDOWN/RICHTEXT</para>
        /// </summary>
        [NameInMap("formatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
        /// </summary>
        [NameInMap("workitemIdentifier")]
        [Validation(Required=false)]
        public string WorkitemIdentifier { get; set; }

    }

}
