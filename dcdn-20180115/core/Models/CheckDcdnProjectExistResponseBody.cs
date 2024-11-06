// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CheckDcdnProjectExistResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CheckDcdnProjectExistResponseBodyContent Content { get; set; }
        public class CheckDcdnProjectExistResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Indicates whether the real-time log delivery project exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public string Exist { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b021e538-9dde-46ed-a1f2-9469da8f3e77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
