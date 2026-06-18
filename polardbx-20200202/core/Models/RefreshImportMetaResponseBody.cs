// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class RefreshImportMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RefreshImportMetaResponseBodyData Data { get; set; }
        public class RefreshImportMetaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The export task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>etx-szr2rr6i*****</para>
            /// </summary>
            [NameInMap("SlinkTaskId")]
            [Validation(Required=false)]
            public string SlinkTaskId { get; set; }

        }

        /// <summary>
        /// <para>The result details of the import or export task. &gt; This parameter is empty unless an exception occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE4F6C34-065F-45AA-B5DC-4B8D816F6305</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
