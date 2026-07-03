// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DeleteBindAccountRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCXXXXXXXX</para>
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
        /// <para>The binding ID. Call the <a href="https://api.aliyun-inc.com/#/publishment/document/cloud-siem/863fdf54478f4cc5877e27c2a5fe9e44?tenantUuid=f382fccd88b94c5c8c864def6815b854%5C&activeTabKey=api%7CListBindAccount">ListBindAccount</a> operation to obtain the binding ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public long? BindId { get; set; }

        /// <summary>
        /// <para>The code for the cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>qcloud: Tencent Cloud</para>
        /// </description></item>
        /// <item><description><para>aliyun: Alibaba Cloud</para>
        /// </description></item>
        /// <item><description><para>hcloud: Huawei Cloud</para>
        /// </description></item>
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
        /// <para>The region where the threat analysis data center is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in mainland China or the China (Hong Kong) region.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in regions outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. An administrator can specify this parameter to perform the operation from the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that are managed by your enterprise.</para>
        /// </description></item>
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
