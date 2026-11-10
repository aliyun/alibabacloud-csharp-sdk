// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateApiKeyQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<UpdateApiKeyQuotaRequestKeys> Keys { get; set; }
        public class UpdateApiKeyQuotaRequestKeys : TeaModel {
            /// <summary>
            /// <para>API KEY</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The daily quota of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("DailyTokenQuota")]
            [Validation(Required=false)]
            public long? DailyTokenQuota { get; set; }

            /// <summary>
            /// <para>The rate limit ratio. This parameter is required when the limit type is set to ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("LimitRate")]
            [Validation(Required=false)]
            public double? LimitRate { get; set; }

            /// <summary>
            /// <para>The quota limit type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ratio: Proportional limit.</description></item>
            /// <item><description>fixed: Fixed value.</description></item>
            /// <item><description>auto: Automatic allocation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fixed</para>
            /// </summary>
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            /// <summary>
            /// <para>The fixed rate limit value. This parameter is required when the limit type is set to fixed.</para>
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
