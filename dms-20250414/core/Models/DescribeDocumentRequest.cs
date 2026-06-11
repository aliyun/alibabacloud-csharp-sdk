// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDocumentRequest : TeaModel {
        /// <summary>
        /// <para>The name of the document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

    }

}
