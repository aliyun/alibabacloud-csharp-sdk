// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CheckBindRamUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FB9DCA3-DA56-5B43-A9A0-68E3D0E6AA84</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: the database account is associated with a RAM user.</description></item>
        /// <item><description><b>false</b>: the database account is not associated with a RAM user.</description></item>
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
