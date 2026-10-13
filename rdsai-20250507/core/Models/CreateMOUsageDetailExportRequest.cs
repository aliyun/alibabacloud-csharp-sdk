// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateMOUsageDetailExportRequest : TeaModel {
        /// <summary>
        /// <para>The API key to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-rds-*****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The inspection end time in the YYYY-MM-DDTHH:mm:ssZ format. The time range between StartTime and EndTime cannot exceed 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10T02:02:20Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The model to call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-flash</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The inspection start time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-05T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
