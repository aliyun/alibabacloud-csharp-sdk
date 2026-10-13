// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateMOQuotaAlertThresholdResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<UpdateMOQuotaAlertThresholdResponseBodyResults> Results { get; set; }
        public class UpdateMOQuotaAlertThresholdResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>API Key</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-*****</para>
            /// </summary>
            [NameInMap("Apikey")]
            [Validation(Required=false)]
            public string Apikey { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
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
            /// <para>The alert threshold percentage. For example, 80 indicates that an alert is triggered when the usage reaches 80%. The alert is reset when the usage drops below this percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0, 100]. 0 clears the alert settings</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public int? ThresholdPercent { get; set; }

        }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
