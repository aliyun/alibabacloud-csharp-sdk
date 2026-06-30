// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateApiKeyQuotaRequest : TeaModel {
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
        /// <para>A list of API keys.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<UpdateApiKeyQuotaRequestKeys> Keys { get; set; }
        public class UpdateApiKeyQuotaRequestKeys : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("DailyTokenQuota")]
            [Validation(Required=false)]
            public long? DailyTokenQuota { get; set; }

            /// <summary>
            /// <para>The limit rate. This parameter is required when <c>LimitType</c> is set to <c>ratio</c>.</para>
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
            /// <item><description><para><c>ratio</c>: Allocates the quota proportionally.</para>
            /// </description></item>
            /// <item><description><para><c>fixed</c>: Allocates a fixed quota.</para>
            /// </description></item>
            /// <item><description><para><c>auto</c>: Allocates the quota automatically.</para>
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
            /// <para>The token quota. This parameter is required when <c>LimitType</c> is set to <c>fixed</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TokenQuota")]
            [Validation(Required=false)]
            public long? TokenQuota { get; set; }

        }

    }

}
