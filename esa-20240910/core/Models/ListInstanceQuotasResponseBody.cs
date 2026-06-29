// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of plan instance quotas.</para>
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
            /// <item><description><b>value</b>: enumeration type. The enumeration range of quota values.</description></item>
            /// <item><description><b>bool</b>: Boolean type. Indicates whether the quota is available.</description></item>
            /// <item><description><b>num</b>: numeric type. The maximum usage of the quota.</description></item>
            /// <item><description><b>range</b>: range type. The value range of the quota.</description></item>
            /// <item><description><b>custom</b>: custom type. Other types that do not fall into the preceding four threshold types.</description></item>
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
        /// <para>The plan instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: The instance is in normal service.</description></item>
        /// <item><description><b>offline</b>: The instance has expired but has not exceeded the grace period and is unavailable.</description></item>
        /// <item><description><b>disable</b>: The instance has been released.</description></item>
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
