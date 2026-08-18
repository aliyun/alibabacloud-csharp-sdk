// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The daily quota of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("DailyTokenQuota")]
        [Validation(Required=false)]
        public long? DailyTokenQuota { get; set; }

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
        /// <para>The API key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-*****</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <para>The quota percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("LimitRate")]
        [Validation(Required=false)]
        public double? LimitRate { get; set; }

        /// <summary>
        /// <para>The quota allocation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ratio: by percentage.</description></item>
        /// <item><description>fixed: by fixed value.</description></item>
        /// <item><description>auto: automatic allocation.</description></item>
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

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The quota limit for the current key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TokenQuota")]
        [Validation(Required=false)]
        public long? TokenQuota { get; set; }

    }

}
