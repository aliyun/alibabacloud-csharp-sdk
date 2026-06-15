// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetTuneProposalByIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTuneProposalByIdResponseBodyData Data { get; set; }
        public class GetTuneProposalByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;example&quot;:&quot;xxxx&quot;}</para>
            /// </summary>
            [NameInMap("JsonContent")]
            [Validation(Required=false)]
            public string JsonContent { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
