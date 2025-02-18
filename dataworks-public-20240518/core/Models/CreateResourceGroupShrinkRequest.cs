// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kqofrgXXXXX</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public string AliyunResourceTagsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// </summary>
        [NameInMap("AutoRenewEnabled")]
        [Validation(Required=false)]
        public bool? AutoRenewEnabled { get; set; }

        /// <summary>
        /// <para>The idempotent identifier of the client is used to ensure idempotent operation of creating a common resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb870033-74c8-4b1b-9664-04c4e7cc3465</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of a common resource group. It must start with a letter and can contain letters, numbers, and underscores (_). It can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common_resource_group</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The duration of the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values: Month and Year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// <para>The billing method of the serverless resource group. Valid values: PrePaid and PostPaid. The value PrePaid indicates the subscription billing method, and the value PostPaid indicates the pay-as-you-go billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Note for creating a common resource group, which can contain letters, Chinese characters, numbers, underscores (_), and a maximum of 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create a serverless resource group for common tasks</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The specifications of the resource group. Unit: compute unit (CU). This parameter is required only when you set the PaymentType parameter to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public int? Spec { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) with which the serverless resource group is associated by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch with which the serverless resource group is associated by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
