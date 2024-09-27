// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SendDocumentAskQuestionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public SendDocumentAskQuestionResponseBodyData Data { get; set; }
        public class SendDocumentAskQuestionResponseBodyData : TeaModel {
            [NameInMap("answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("document")]
            [Validation(Required=false)]
            public List<string> Document { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
