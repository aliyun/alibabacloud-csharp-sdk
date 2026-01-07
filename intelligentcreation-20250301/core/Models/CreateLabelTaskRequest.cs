// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20250301.Models
{
    public class CreateLabelTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket-name.oss-zhangjiakou.aliyuncs.com/path/filename.jsonl">https://bucket-name.oss-zhangjiakou.aliyuncs.com/path/filename.jsonl</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdefg1234567</para>
        /// </summary>
        [NameInMap("IdempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LabelTemplateId")]
        [Validation(Required=false)]
        public string LabelTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1733766254635026</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
