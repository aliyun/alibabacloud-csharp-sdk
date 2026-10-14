// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class HealthCheckConfig : TeaModel {
        /// <summary>
        /// <para>The check interval in seconds. Default value: 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CheckInterval")]
        [Validation(Required=false)]
        public int? CheckInterval { get; set; }

        /// <summary>
        /// <para>The failure count. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FailureCount")]
        [Validation(Required=false)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// <para>The port number. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values: TCP and UDP. This parameter is required only in Continuous mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The timeout period for a single check in seconds. Default value: 5 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
