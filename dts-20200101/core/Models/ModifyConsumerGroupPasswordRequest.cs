// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumerGroupPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group. You can call the <a href="https://help.aliyun.com/document_detail/122886.html">DescribeConsumerGroup</a> operation to query the consumer group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtswc411cg617p****</para>
        /// </summary>
        [NameInMap("ConsumerGroupID")]
        [Validation(Required=false)]
        public string ConsumerGroupID { get; set; }

        /// <summary>
        /// <para>The name of the consumer group. The name cannot exceed 128 characters in length. We recommend that you use an informative name for easy identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// <para>The new password of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>A password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        /// <summary>
        /// <para>The username of the consumer group. You can call the <a href="https://help.aliyun.com/document_detail/122886.html">DescribeConsumerGroup</a> operation to query the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the <b>DescribeSubscriptionInstances</b> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsg2m10r1x15a****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// <para>The new password of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>A password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test654321</para>
        /// </summary>
        [NameInMap("consumerGroupNewPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupNewPassword { get; set; }

    }

}
