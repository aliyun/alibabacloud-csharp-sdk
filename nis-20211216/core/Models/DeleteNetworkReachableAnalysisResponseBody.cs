// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkReachableAnalysisResponseBody : TeaModel {
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
        /// <para>4838F3F2-30E1-5D82-B25A-B9FE33BC3E25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
