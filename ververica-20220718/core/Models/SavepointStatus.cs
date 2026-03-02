// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SavepointStatus : TeaModel {
        /// <summary>
        /// <para>The details of the failure to create a savepoint for the deployment.</para>
        /// </summary>
        [NameInMap("failure")]
        [Validation(Required=false)]
        public SavepointFailure Failure { get; set; }

        /// <summary>
        /// <para>The status of the savepoint that is created for the deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STARTED</description></item>
        /// <item><description>COMPLETED</description></item>
        /// <item><description>FAILED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
