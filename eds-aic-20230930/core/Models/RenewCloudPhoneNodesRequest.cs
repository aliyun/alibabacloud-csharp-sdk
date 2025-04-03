// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RenewCloudPhoneNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the auto-renewal feature. In this case, the system automatically renews the instance upon expiration.</description></item>
        /// <item><description>false (default): disables the auto-renewal feature. In this case, you need to manually renew the instance upon expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The cloud phone matrix IDs.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>PeriodUnit</c> is set to <b>year</b>: 1.</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <b>month</b>: 1, 2, 3, and 6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
