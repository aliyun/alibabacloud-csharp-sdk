// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListIdentifyModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which can be used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of detection models or rules.</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<ListIdentifyModelsResponseBodyRuleList> RuleList { get; set; }
        public class ListIdentifyModelsResponseBodyRuleList : TeaModel {
            /// <summary>
            /// <para>The ID of the detection model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the detection model or rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phone Number</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
