// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSaleResponseBody : TeaModel {
        /// <summary>
        /// <para>The sales information about the configuration assessment quota.</para>
        /// </summary>
        [NameInMap("CheckSale")]
        [Validation(Required=false)]
        public GetCheckSaleResponseBodyCheckSale CheckSale { get; set; }
        public class GetCheckSaleResponseBodyCheckSale : TeaModel {
            /// <summary>
            /// <para>The consumed quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ConsumeCount")]
            [Validation(Required=false)]
            public long? ConsumeCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is an existing user and whether the user uses the configuration assessment feature before the feature is released for sale on July 07, 2023. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: existing user</description></item>
            /// <item><description><b>false</b>: new user</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LoyalUser")]
            [Validation(Required=false)]
            public bool? LoyalUser { get; set; }

            /// <summary>
            /// <para>The purchased quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PurchaseCount")]
            [Validation(Required=false)]
            public long? PurchaseCount { get; set; }

            /// <summary>
            /// <para>The type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: a user who can use all check items.</description></item>
            /// <item><description><b>2</b>: an user who can only use the check items before the release of the feature on July 07, 2023. This type of users must upgrade Security Center before the users can use all check items.</description></item>
            /// <item><description><b>3</b>: a new user who cannot use the configuration assessment feature. This type of users must make a purchase before the users can use the feature.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
