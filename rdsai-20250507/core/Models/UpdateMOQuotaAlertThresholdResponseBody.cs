// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateMOQuotaAlertThresholdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result list.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<UpdateMOQuotaAlertThresholdResponseBodyResults> Results { get; set; }
        public class UpdateMOQuotaAlertThresholdResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-*****</para>
            /// </summary>
            [NameInMap("Apikey")]
            [Validation(Required=false)]
            public string Apikey { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-o*****1</para>
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
            /// <para>The key type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system / custom</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            /// <summary>
            /// <para>The alert threshold percentage. For example, a value of 80 triggers an alert when usage reaches 80% of the usage quota. The alert is reset after the usage falls below this percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0, 100]，0 会清理告警设置</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public int? ThresholdPercent { get; set; }

        }

        /// <summary>
        /// <para>A value of <c>true</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
