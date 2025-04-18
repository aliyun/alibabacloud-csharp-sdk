// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkPathResponseBody : TeaModel {
        /// <summary>
        /// <para>Result of operation.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Delete Success.</description></item>
        /// <item><description><b>false</b>: Delete Fail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4331873-C534-590F-A905-F66C53B88A47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
