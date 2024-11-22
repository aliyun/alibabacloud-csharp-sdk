// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The quotas in the plan.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListInstanceQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListInstanceQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customHttpCert</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public string QuotaValue { get; set; }

            /// <summary>
            /// <para>The threshold type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>value: enumerates the values of the quota.</description></item>
            /// <item><description>bool: specifies whether the quota is available.</description></item>
            /// <item><description>num: the upper limit of the quota.</description></item>
            /// <item><description>range: the value range for the quota.</description></item>
            /// <item><description>custom: other types than the preceding four quota threshold types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bool</para>
            /// </summary>
            [NameInMap("QuotaValueType")]
            [Validation(Required=false)]
            public string QuotaValueType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The plan status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: The plan is in service.</description></item>
        /// <item><description>offline: The plan has expired within an allowable period. In this state, the plan is unavailable.</description></item>
        /// <item><description>disable: The plan is released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
