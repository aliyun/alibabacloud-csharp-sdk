// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class SLSCollectConfig : TeaModel {
        /// <summary>
        /// <para>The log path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("LogPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

        /// <summary>
        /// <para>The log type. The following types of logs are supported:</para>
        /// <list type="bullet">
        /// <item><description>File collection logs</description></item>
        /// <item><description>Standard output logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>file_log</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The name of the Logstore. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be unique in a project.</description></item>
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sag-shanghai</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name for the Logtail configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>******-access-log-collector</para>
        /// </summary>
        [NameInMap("LogtailName")]
        [Validation(Required=false)]
        public string LogtailName { get; set; }

        /// <summary>
        /// <para>The name of the machine group of Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Log Service Group</para>
        /// </summary>
        [NameInMap("MachineGroup")]
        [Validation(Required=false)]
        public string MachineGroup { get; set; }

        /// <summary>
        /// <para>The name of the SLS project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
