// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateMigrationJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter. This parameter will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a value from your client to ensure that the value is unique among different requests. The <b>ClientToken</b> parameter supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The specification of the data migration instance. Valid values: <b>small</b>, <b>medium</b>, <b>large</b>, <b>xlarge</b>, and <b>2xlarge</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For the test performance of each specification, see <a href="https://help.aliyun.com/document_detail/26606.html">Data migration specifications</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For instance specifications and pricing, see <a href="https://help.aliyun.com/document_detail/117780.html">Pricing</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xlarge</para>
        /// </summary>
        [NameInMap("MigrationJobClass")]
        [Validation(Required=false)]
        public string MigrationJobClass { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the data migration instance, which is the region of the destination database instance. For more information, see the supported <a href="https://help.aliyun.com/document_detail/141033.html">region list</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region of the data migration instance. You do not need to specify this parameter. This parameter will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
