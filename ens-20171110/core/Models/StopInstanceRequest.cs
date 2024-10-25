// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly stop the servers.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: forcibly stops the instance.</description></item>
        /// <item><description><b>false</b>: normally stops the servers. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public string ForceStop { get; set; }

        /// <summary>
        /// <para>The ID of the instance that you want to stop. You can specify only one instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-instanceid****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
