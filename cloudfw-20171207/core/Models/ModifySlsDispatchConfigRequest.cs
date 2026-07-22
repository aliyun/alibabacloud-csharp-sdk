// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifySlsDispatchConfigRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configuration to modify.</para>
        /// <details>
        /// <summary>Format for version 1</summary>
        /// {"global":{"slsRegionId":"ap-southeast-1","logTime":180,"logStorage":1000}}
        /// </details>
        /// 
        /// <details>
        /// <summary>Format for version 2</summary>
        /// {"cn":{"slsRegionId":"ap-southeast-1","logTime":180,"logStorage":3000},"intl":{"slsRegionId":"ap-southeast-1","logTime":180,"logStorage":2000}}
        /// </details>
        /// The fields are described as follows:
        /// 
        /// <list type="bullet">
        /// <item><description>slsRegionId: The region ID to which logs are delivered.</description></item>
        /// <item><description>logTime: The storage duration of logs. Unit: days.</description></item>
        /// <item><description>logStorage: The log storage capacity. Unit: GB. The total capacity specified must not exceed the total capacity purchased by the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;global&quot;:{&quot;slsRegionId&quot;:&quot;cn-hangzhou&quot;,&quot;logTime&quot;:180,&quot;logStorage&quot;:1000}}</para>
        /// </summary>
        [NameInMap("DetailConfig")]
        [Validation(Required=false)]
        public string DetailConfig { get; set; }

        /// <summary>
        /// <para>The log version. A value of 1 indicates one Logstore. A value of 2 indicates two Logstores.</para>
        /// <remarks>
        /// <para>Notice: If ModifyType is set to version, set LogVersion to the target version. If ModifyType is set to config, set LogVersion to the current version of the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogVersion")]
        [Validation(Required=false)]
        public int? LogVersion { get; set; }

        /// <summary>
        /// <para>The modification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>version: The version is changed. For example, the version is changed from 1 (logs are delivered to one Logstore) to 2 (logs are delivered to two Logstores).</para>
        /// </description></item>
        /// <item><description><para>config: The configuration is changed. For example, the log delivery region or the storage duration of logs is modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>version</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

    }

}
