// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListRuleConditionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRuleConditionsResponseBodyResult> Result { get; set; }
        public class ListRuleConditionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The type of the filtering condition for the item selection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QUERY_ITEM_TYPE</para>
            /// </summary>
            [NameInMap("selectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            /// <summary>
            /// <para>The specific value of the filtering condition for the item selection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("selectValue")]
            [Validation(Required=false)]
            public string SelectValue { get; set; }

            /// <summary>
            /// <para>The operation on the filtering condition for the item selection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QUERY_VALUE_IN</para>
            /// </summary>
            [NameInMap("selectionOperation")]
            [Validation(Required=false)]
            public string SelectionOperation { get; set; }

        }

    }

}
