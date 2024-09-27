// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteEdgeMachineRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully delete the cloud-native box. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: forcefully deletes the cloud-native box.</description></item>
        /// <item><description><c>false</c>: does not forcefully delete the cloud-native box.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

    }

}
