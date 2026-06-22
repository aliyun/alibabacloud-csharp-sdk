// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSaleResponseBody : TeaModel {
        /// <summary>
        /// <para>The sales information of cloud service configuration check.</para>
        /// </summary>
        [NameInMap("CheckSale")]
        [Validation(Required=false)]
        public GetCheckSaleResponseBodyCheckSale CheckSale { get; set; }
        public class GetCheckSaleResponseBodyCheckSale : TeaModel {
            /// <summary>
            /// <para>The number of consumed authorized quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ConsumeCount")]
            [Validation(Required=false)]
            public long? ConsumeCount { get; set; }

            [NameInMap("InstanceConsumeCount")]
            [Validation(Required=false)]
            public long? InstanceConsumeCount { get; set; }

            [NameInMap("InstanceHybridPostLatestCycledResourceCount")]
            [Validation(Required=false)]
            public long? InstanceHybridPostLatestCycledResourceCount { get; set; }

            [NameInMap("InstancePostConsumeCount")]
            [Validation(Required=false)]
            public long? InstancePostConsumeCount { get; set; }

            [NameInMap("InstancePurchaseCount")]
            [Validation(Required=false)]
            public long? InstancePurchaseCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is an existing user who used the cloud service configuration check feature before the sales feature was released on July 7, 2023. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The user is an existing user.</description></item>
            /// <item><description><b>false</b>: The user is not an existing user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LoyalUser")]
            [Validation(Required=false)]
            public bool? LoyalUser { get; set; }

            /// <summary>
            /// <para>The number of purchased authorized quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PurchaseCount")]
            [Validation(Required=false)]
            public long? PurchaseCount { get; set; }

            /// <summary>
            /// <para>The type of the sales user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: full-feature user who can use all check items.</description></item>
            /// <item><description><b>2</b>: user who needs to upgrade and can only use check items that were available before the sales feature was released on July 7, 2023.</description></item>
            /// <item><description><b>3</b>: user who needs to purchase the feature and cannot use the cloud service configuration check feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SaleUserType")]
            [Validation(Required=false)]
            public int? SaleUserType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
