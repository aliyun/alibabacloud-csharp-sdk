// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceRenewPriceRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The numeric part of the purchase duration. This parameter is used together with PeriodUnit to specify the complete purchase duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit part of the purchase duration. This parameter is used together with Period to specify the complete purchase duration. Valid combinations of Period and PeriodUnit:</para>
        /// <list type="bullet">
        /// <item><description>1 Week</description></item>
        /// <item><description>1 Month</description></item>
        /// <item><description>2 Month</description></item>
        /// <item><description>3 Month</description></item>
        /// <item><description>6 Month</description></item>
        /// <item><description>1 Year</description></item>
        /// <item><description>2 Year</description></item>
        /// <item><description>3 Year</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is invalid. If the request parameters do not match the combinations listed above, such as <c>2 Week</c>, the call to this operation succeeds, but an error occurs during the order placement phase.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
