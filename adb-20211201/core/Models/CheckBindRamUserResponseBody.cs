// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CheckBindRamUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FB9DCA3-DA56-5B43-A9A0-68E3D0E6AA84</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result returned by the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The current Resource Access Management (RAM) user is attached to a database account.</description></item>
        /// <item><description><b>false</b>: The current Resource Access Management (RAM) user is not attached to a database account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
