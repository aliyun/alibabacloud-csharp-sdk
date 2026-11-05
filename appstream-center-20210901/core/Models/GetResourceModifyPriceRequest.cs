// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceModifyPriceRequest : TeaModel {
        /// <summary>
        /// <para>The total number of subscription resource nodes after the scale-out. Unit: nodes.</para>
        /// <para><b>The value must be greater than the current number of purchased nodes in the delivery group and cannot exceed the node quota of the account.</b> This parameter does not represent the number of added nodes or the number of sessions.</para>
        /// <para>For example, if there is currently 1 node and you want to scale out to 2 nodes, set this parameter to 2, which indicates that the final total number is 2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>The ID of the delivery group to be scaled out. You can query only one delivery group at a time.</para>
        /// <para>The delivery group must belong to the current account and match ProductType. It must be purchased by node, use the subscription billing method, have a normal order status, and be associated with a resource node pool.</para>
        /// <para>You can obtain the cloud app delivery group ID by calling <a href="https://api.aliyun.com/document/appstream-center/2021-09-01/ListAppInstanceGroup">ListAppInstanceGroup</a>. You can call <a href="https://api.aliyun.com/document/appstream-center/2021-09-01/GetAppInstanceGroup">GetAppInstanceGroup</a> to further verify the current configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The product type, which must match the product to which the target delivery group belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: Wuying Cloud App. Queries the resource scale-out pricing for a cloud app delivery group.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser. Applies only to subscription browser delivery groups purchased by node.</description></item>
        /// </list>
        /// <para>This operation does not apply to browser groups that use the pay-as-you-go billing method or are billed by monthly active users (MAU).</para>
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
