// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateMOQuotaAlertThresholdRequest : TeaModel {
        /// <summary>
        /// <para>A list of API keys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Apikey")]
        [Validation(Required=false)]
        public List<UpdateMOQuotaAlertThresholdRequestApikey> Apikey { get; set; }
        public class UpdateMOQuotaAlertThresholdRequestApikey : TeaModel {
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
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
