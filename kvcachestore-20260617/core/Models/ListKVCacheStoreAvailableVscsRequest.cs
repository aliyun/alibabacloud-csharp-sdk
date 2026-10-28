// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableVscsRequest : TeaModel {
        /// <summary>
        /// <para>The cross-account authorization role chain, used for cross-account VSC queries in ECS or EFLO scenarios.</para>
        /// </summary>
        [NameInMap("Arns")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAvailableVscsRequestArns> Arns { get; set; }
        public class ListKVCacheStoreAvailableVscsRequestArns : TeaModel {
            /// <summary>
            /// <para>The target UID for role assumption.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1193522024229156</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1028257687084022:role/zeus-locationservicerole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The role type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>service</description></item>
            /// <item><description>user</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// <para>The compute instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-55kl5wq6j6kvtl4xu5tgunddu</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The compute instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// <item><description>EFLO</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The KVCacheStore instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcs-cn-5y44vuqiz001</para>
        /// </summary>
        [NameInMap("KvcsId")]
        [Validation(Required=false)]
        public string KvcsId { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
