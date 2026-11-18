// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalKnowResult : TeaModel {
        /// <summary>
        /// <para>The list of recognized entity property results. An empty array is returned if no entities are recognized.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<MedicalKnowledgeInfo> Messages { get; set; }

        /// <summary>
        /// <para>The query context information, such as the original query content.</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public MultimodalQueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>The ID of the request, which can be provided for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35E5608A-A737-2038-AFB6-D9D34C6BFD9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search information for the query, such as the search duration.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public UnifiedSearchInformation SearchInformation { get; set; }

    }

}
