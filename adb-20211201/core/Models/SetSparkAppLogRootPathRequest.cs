// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SetSparkAppLogRootPathRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-dbclusterid</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The path of Object Storage Service (OSS) logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://path/to/log</para>
        /// </summary>
        [NameInMap("OssLogPath")]
        [Validation(Required=false)]
        public string OssLogPath { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the default OSS log path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseDefaultOss")]
        [Validation(Required=false)]
        public bool? UseDefaultOss { get; set; }

    }

}
