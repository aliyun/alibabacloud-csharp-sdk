// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20241107.Models
{
    public class CreateLabelTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://test/test</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7caa09aa60204086909ba3958810a567</para>
        /// </summary>
        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1_for_7_label_v1</para>
        /// </summary>
        [NameInMap("labelTemplateId")]
        [Validation(Required=false)]
        public string LabelTemplateId { get; set; }

    }

}
