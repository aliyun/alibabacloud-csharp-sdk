// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ExecuteLogQueryRequest : TeaModel {
        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to pack non-standard fields into the extend_content field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ExtendContentPacked")]
        [Validation(Required=false)]
        public string ExtendContentPacked { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English. This parameter is actually required. If it is not provided, the service returns a 400 error. Explicitly specify zh or en.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The log query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;alert_level\&quot;:[\&quot;5\&quot;,\&quot;4\&quot;,\&quot;3\&quot;,\&quot;2\&quot;,\&quot;1\&quot;]}</para>
        /// </summary>
        [NameInMap("LogCondition")]
        [Validation(Required=false)]
        public string LogCondition { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project. This parameter is required when executing a log query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slsaudit-center-173326*******-cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogProjectName")]
        [Validation(Required=false)]
        public string LogProjectName { get; set; }

        /// <summary>
        /// <para>The Simple Log Service query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("LogQuery")]
        [Validation(Required=false)]
        public string LogQuery { get; set; }

        /// <summary>
        /// <para>The ID of the log storage region. This parameter is actually required when you execute a log query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project. This parameter is required when executing a log query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>huawei-cn-cfw</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The ID of the user for data ingestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public long? LogUserId { get; set; }

        /// <summary>
        /// <para>The normalization schema ID. This parameter is required if packing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF_ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
