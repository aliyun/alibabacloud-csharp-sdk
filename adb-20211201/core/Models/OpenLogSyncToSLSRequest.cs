// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenLogSyncToSLSRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ADBMYSQL_AUDIT_LOG</b></description></item>
        /// <item><description><b>ADBMYSQL_INSERT_LOG</b></description></item>
        /// </list>
        /// <para>Default value: <c>ADBMYSQL_AUDIT_LOG</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADBMYSQL_AUDIT_LOG</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service LogStore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbmysql-audit-log</para>
        /// </summary>
        [NameInMap("TargetLogStore")]
        [Validation(Required=false)]
        public string TargetLogStore { get; set; }

        /// <summary>
        /// <para>The Simple Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log-service-****-cn-shenzhen</para>
        /// </summary>
        [NameInMap("TargetProject")]
        [Validation(Required=false)]
        public string TargetProject { get; set; }

    }

}
