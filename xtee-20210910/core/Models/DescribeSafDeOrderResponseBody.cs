// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafDeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafDeOrderResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafDeOrderResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1728008155799</para>
            /// </summary>
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public long? ExpirationDate { get; set; }

            /// <summary>
            /// <para>Based on the product type subscribed by the customer, the console permissions are divided into three categories:</para>
            /// <pre><c> 1. New Customer: Has not purchased/subscribed to any service.
            ///  2. Old Customer (Subscription): Customers who have purchased the SAF product.
            ///  3. Pay-As-You-Go: Customers who have purchased the SAF_BAG product or activated SAF_POS.
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("openUserType")]
            [Validation(Required=false)]
            public int? OpenUserType { get; set; }

        }

    }

}
