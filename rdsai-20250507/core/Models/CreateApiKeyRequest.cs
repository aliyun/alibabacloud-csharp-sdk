// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateApiKeyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("DailyTokenQuota")]
        [Validation(Required=false)]
        public long? DailyTokenQuota { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The API key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-*****</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <para>The proportion of the total quota to allocate. This parameter applies only when <c>LimitType</c> is set to <c>ratio</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("LimitRate")]
        [Validation(Required=false)]
        public double? LimitRate { get; set; }

        /// <summary>
        /// <para>The limit type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ratio</c>: Sets the limit as a ratio of the total available quota.</para>
        /// </description></item>
        /// <item><description><para><c>fixed</c>: Sets the limit to a fixed number of tokens.</para>
        /// </description></item>
        /// <item><description><para><c>auto</c>: Automatically allocates the quota.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fixed</para>
        /// </summary>
        [NameInMap("LimitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <para>The number of API keys to create. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The fixed token quota for the API key. This parameter applies only when <c>LimitType</c> is set to <c>fixed</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TokenQuota")]
        [Validation(Required=false)]
        public long? TokenQuota { get; set; }

    }

}
