// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ServiceStatus : TeaModel {
        /// <summary>
        /// <para>Indicates whether the service is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Current status.</para>
        /// <list type="bullet">
        /// <item><description>Opened: The service is activated.</description></item>
        /// <item><description>NotExist: The service does not exist.</description></item>
        /// <item><description>Opening: The service is activating.</description></item>
        /// <item><description>Closed: The service has overdue payments and is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotExist</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
