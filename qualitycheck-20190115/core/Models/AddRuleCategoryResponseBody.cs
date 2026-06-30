// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AddRuleCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddRuleCategoryResponseBodyData Data { get; set; }
        public class AddRuleCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the newly added rule category is selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Select")]
            [Validation(Required=false)]
            public bool? Select { get; set; }

            /// <summary>
            /// <para>Rule category ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>D10B9203-1A6A-49DA-AE56-4D160DD37DBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
