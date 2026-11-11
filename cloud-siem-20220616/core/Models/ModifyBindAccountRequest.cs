// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ModifyBindAccountRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCXXXXXXXXX</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The name of the multi-cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_account_xxx</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the binding record. This is the BindId returned by the ListBindAccount operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public long? BindId { get; set; }

        /// <summary>
        /// <para>The code of the multi-cloud provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hcloud</b>: Huawei Cloud.</description></item>
        /// <item><description><b>qcloud</b>: Tencent Cloud.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hcloud</para>
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// <para>The region where the threat detection and response (CTDR) data management center resides. Select the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets belong to the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: The assets belong to regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member account to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: The view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
