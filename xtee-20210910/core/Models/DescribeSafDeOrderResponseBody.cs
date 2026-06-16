// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafDeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafDeOrderResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafDeOrderResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1728008155799</para>
            /// </summary>
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public long? ExpirationDate { get; set; }

            /// <summary>
            /// <para>The console permissions are classified into three categories based on the commodity type activated by the customer:</para>
            /// <pre><c> 1. New customer: has not purchased or activated any service.
            ///  2. Existing customer (subscription): has purchased the saf commodity.
            ///  3. Pay-as-you-go: has purchased the saf_bag commodity or activated saf_pos.
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("openUserType")]
            [Validation(Required=false)]
            public int? OpenUserType { get; set; }

            /// <summary>
            /// <para>The activated region permission addresses.</para>
            /// </summary>
            [NameInMap("regions")]
            [Validation(Required=false)]
            public List<DescribeSafDeOrderResponseBodyResultObjectRegions> Regions { get; set; }
            public class DescribeSafDeOrderResponseBodyResultObjectRegions : TeaModel {
                /// <summary>
                /// <para>The expiration date (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2117750400000</para>
                /// </summary>
                [NameInMap("expirationDate")]
                [Validation(Required=false)]
                public long? ExpirationDate { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The specification type:</para>
                /// <para> 1: Basic Edition
                ///  2: Advanced Edition
                ///  3: Premium Edition
                ///  4: Ultimate Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public int? Specification { get; set; }

            }

        }

    }

}
