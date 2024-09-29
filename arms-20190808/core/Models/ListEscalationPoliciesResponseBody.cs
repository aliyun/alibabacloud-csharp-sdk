// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEscalationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned objects.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListEscalationPoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListEscalationPoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The list of escalation policies.</para>
            /// </summary>
            [NameInMap("EscalationPolicies")]
            [Validation(Required=false)]
            public List<ListEscalationPoliciesResponseBodyPageBeanEscalationPolicies> EscalationPolicies { get; set; }
            public class ListEscalationPoliciesResponseBodyPageBeanEscalationPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the escalation policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the escalation policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod escalation policy</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
