// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UploadBookRequest : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Docs")]
        [Validation(Required=false)]
        public List<UploadBookRequestDocs> Docs { get; set; }
        public class UploadBookRequestDocs : TeaModel {
            [NameInMap("DocName")]
            [Validation(Required=false)]
            public string DocName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx/ccc.pdf">http://xxx/ccc.pdf</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ipe7d81yq4sl5jmk</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
