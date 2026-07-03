// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ExecuteLogQueryRequest : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to pack non-standard fields into the extension field extend_content. Valid values:</para>
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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LogCondition")]
        [Validation(Required=false)]
        public string LogCondition { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project name.</para>
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
        /// <para>The log storage region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>huawei-cn-cfw</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The user ID for data access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public long? LogUserId { get; set; }

        /// <summary>
        /// <para>If packing is enabled, you must specify NormalizationSchemaId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF_ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis data management center is located. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the asset is in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: the asset is outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
