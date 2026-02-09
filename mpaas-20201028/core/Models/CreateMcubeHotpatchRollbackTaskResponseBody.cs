// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMcubeHotpatchRollbackTaskResponseBody : TeaModel {
        [NameInMap("CreateHotpatchRollbackTaskResult")]
        [Validation(Required=false)]
        public CreateMcubeHotpatchRollbackTaskResponseBodyCreateHotpatchRollbackTaskResult CreateHotpatchRollbackTaskResult { get; set; }
        public class CreateMcubeHotpatchRollbackTaskResponseBodyCreateHotpatchRollbackTaskResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>06D5CA0C-F5D4-5D64-987E-D221C88AED29</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1543</para>
            /// </summary>
            [NameInMap("RollbackTaskId")]
            [Validation(Required=false)]
            public string RollbackTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
