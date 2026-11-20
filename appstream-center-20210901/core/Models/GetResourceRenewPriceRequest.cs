// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceRenewPriceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to retrieve the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The numeric value of the subscription duration. This parameter is used together with PeriodUnit to specify the complete subscription duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Request parameter is used together with Period to specify the complete subscription duration. Valid combinations of Period and PeriodUnit are as follows:</para>
        /// <list type="bullet">
        /// <item><description>1 Week (1 week)</description></item>
        /// <item><description>1 Month (1 month)</description></item>
        /// <item><description>2 Months (2 months)</description></item>
        /// <item><description>3 Months (3 months)</description></item>
        /// <item><description>6 Months (6 months)</description></item>
        /// <item><description>1 Year (1 year)</description></item>
        /// <item><description>2 Years (2 years)</description></item>
        /// <item><description>3 Years (3 years)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Request parameter is case-sensitive. For example, Week is valid, but week is invalid. If the combination of Period and PeriodUnit does not match the preceding valid combinations, such as 2 Week, the API call succeeds but an error occurs during the order placement stage.</para>
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
