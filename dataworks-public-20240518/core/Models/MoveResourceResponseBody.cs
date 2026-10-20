// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MoveResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F332BED4-DD73-5972-A9C2-642BA6CFXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call is successful.</para>
        /// </description></item>
        /// <item><description><para>false: The call fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
