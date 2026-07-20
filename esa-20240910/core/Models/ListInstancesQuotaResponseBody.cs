// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstancesQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>siteCount</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// <para>The threshold type of the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>value</b>: Enumeration type. The enumeration range of quota values.</description></item>
        /// <item><description><b>bool</b>: Boolean type. Indicates whether the quota is available.</description></item>
        /// <item><description><b>num</b>: Numeric type. The upper limit of the quota usage.</description></item>
        /// <item><description><b>range</b>: Range type. The value range of the quota.</description></item>
        /// <item><description><b>custom</b>: Custom type. Other types beyond the four threshold types above.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bool</para>
        /// </summary>
        [NameInMap("QuotaValueType")]
        [Validation(Required=false)]
        public string QuotaValueType { get; set; }

        /// <summary>
        /// <para>The list of quota values.</para>
        /// </summary>
        [NameInMap("QuotaValues")]
        [Validation(Required=false)]
        public List<ListInstancesQuotaResponseBodyQuotaValues> QuotaValues { get; set; }
        public class ListInstancesQuotaResponseBodyQuotaValues : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esa-site-blea5hv7m0ow</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public string QuotaValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
