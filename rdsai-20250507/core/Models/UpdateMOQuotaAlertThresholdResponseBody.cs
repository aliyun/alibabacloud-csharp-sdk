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
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-o*****1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>api-*****</para>
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>system / custom</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public int? ThresholdPercent { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
