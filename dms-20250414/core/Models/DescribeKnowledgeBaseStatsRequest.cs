// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeKnowledgeBaseStatsRequest : TeaModel {
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
