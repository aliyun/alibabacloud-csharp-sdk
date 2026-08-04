// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The consumer group name.</para>
        /// <list type="bullet">
        /// <item><description>Reserved instances:
        /// Can contain letters, digits, underscores (_), hyphens (-), and periods (.). The value must be 3 to 64 characters in length.</description></item>
        /// <item><description>Serverless instances:
        /// Can contain only letters, digits, and special characters &quot;@._*$#^!&amp;-&quot;. The value must be 1 to 249 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-0pp1l9z8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateConsumerGroupRequestTag> Tag { get; set; }
        public class CreateConsumerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>The tag key cannot be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
