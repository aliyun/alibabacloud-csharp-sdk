// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SubFolder : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a579aec9-1d5e-3382-9d65-9887ff6cfaff</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95c0787c-408f-4e1f-88ba-ef0a84a2c2ee</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

    }

}
