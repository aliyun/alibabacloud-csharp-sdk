// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class RunLog : TeaModel {
        /// <summary>
        /// <para>The path of the startup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path/to/startup</para>
        /// </summary>
        [NameInMap("driverStartup")]
        [Validation(Required=false)]
        public string DriverStartup { get; set; }

        /// <summary>
        /// <para>The path of the stderr file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path/to/stderr</para>
        /// </summary>
        [NameInMap("driverStdError")]
        [Validation(Required=false)]
        public string DriverStdError { get; set; }

        /// <summary>
        /// <para>The path of the stdout file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path/to/stdout</para>
        /// </summary>
        [NameInMap("driverStdOut")]
        [Validation(Required=false)]
        public string DriverStdOut { get; set; }

        /// <summary>
        /// <para>The path of the syslog file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path/to/syslog</para>
        /// </summary>
        [NameInMap("driverSyslog")]
        [Validation(Required=false)]
        public string DriverSyslog { get; set; }

    }

}
