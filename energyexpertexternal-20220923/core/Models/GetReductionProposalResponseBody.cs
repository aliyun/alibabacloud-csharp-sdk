// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetReductionProposalResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetReductionProposalResponseBodyData Data { get; set; }
        public class GetReductionProposalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Proactive carbon reduction recommendations and advice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reduce one-drop usage</para>
            /// </summary>
            [NameInMap("reduction")]
            [Validation(Required=false)]
            public string Reduction { get; set; }

            /// <summary>
            /// <para>Active carbon reduction assessment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trying Energy Expert for a more detailed assessment.</para>
            /// </summary>
            [NameInMap("reductionEvaluation")]
            [Validation(Required=false)]
            public string ReductionEvaluation { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
