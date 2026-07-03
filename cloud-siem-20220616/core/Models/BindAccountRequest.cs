// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class BindAccountRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCXXXXXXXX</para>
        /// </summary>
        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxxxx</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The name of the multicloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The code of the cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliyun: Alibaba Cloud</description></item>
        /// <item><description>hcloud: Huawei Cloud</description></item>
        /// <item><description>qcloud: Tencent Cloud</description></item>
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
        /// <para>The region where the data management center of Threat Analysis is located. You must select a region for the data management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets are deployed in the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Your assets are deployed in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to whose view the administrator switches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view.</para>
        /// <list type="bullet">
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts that belong to the enterprise.</description></item>
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
