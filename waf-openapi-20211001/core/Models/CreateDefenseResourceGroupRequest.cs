// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The protected objects to add to the protected object group. You can add multiple protected objects. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1.aliyundoc.com,test2.aliyundoc.com</para>
        /// </summary>
        [NameInMap("AddList")]
        [Validation(Required=false)]
        public string AddList { get; set; }

        /// <summary>
        /// <para>The description of the protected object group. The description can be up to 512 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_domain</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the protected object group. The name must be 1 to 255 characters long and can contain Chinese characters, letters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group221</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to view the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
