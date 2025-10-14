// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchGetExpressionFieldsRequest : TeaModel {
        /// <summary>
        /// <para>List of expressions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<BatchGetExpressionFieldsRequestExpressions> Expressions { get; set; }
        public class BatchGetExpressionFieldsRequestExpressions : TeaModel {
            /// <summary>
            /// <para>Content of the expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip.src eq 1.1.1.1</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The sequence number of the expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>WAF Phase</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("PlanNameEn")]
        [Validation(Required=false)]
        public string PlanNameEn { get; set; }

        /// <summary>
        /// <para>Site ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
