// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalAnswerResult : TeaModel {
        /// <summary>
        /// <para>The list of medical Q&amp;A answers. An empty array is returned if the question is empty or no content is matched.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<MedicalAnswerMessage> Messages { get; set; }

        /// <summary>
        /// <para>The query context information, such as the original query content.</para>
        /// </summary>
        [NameInMap("queryContext")]
        [Validation(Required=false)]
        public MultimodalQueryContext QueryContext { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can provide this ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35E5608A-A737-2038-AFB6-D9D34C6BFD9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search information, such as the execution duration.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public UnifiedSearchInformation SearchInformation { get; set; }

    }

}
