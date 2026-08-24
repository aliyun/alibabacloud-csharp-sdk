// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetOneMetaOssieModelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocFormat")]
        [Validation(Required=false)]
        public string DocFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

    }

}
