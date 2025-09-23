// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadTenderDocRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://default/aimiaobi-service-prod/aimiaobi/materialDocument/1601892701595700_10169811/208757545922605632_yst-test_9eb7d7e1deb543d88e2d6f1c9df456ef.docx</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tender.pdf</para>
        /// </summary>
        [NameInMap("TenderDocName")]
        [Validation(Required=false)]
        public string TenderDocName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-az2gglkjauwnnhpq</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
