// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class CreateMultiModelKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the created AnalyticDB for MySQL cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-***</para>
        /// </summary>
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// <para>The name of the created multimodal knowledge engine service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mmkb-***</para>
        /// </summary>
        [NameInMap("MmkbName")]
        [Validation(Required=false)]
        public string MmkbName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B47EED99-BFA5-529D-8D85-A6642421D390</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
