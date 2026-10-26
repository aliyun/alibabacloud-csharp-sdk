// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataMaskingEncryptionAlgorithmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of column encryption algorithms.</para>
        /// </summary>
        [NameInMap("Algorithms")]
        [Validation(Required=false)]
        public List<ListDataMaskingEncryptionAlgorithmsResponseBodyAlgorithms> Algorithms { get; set; }
        public class ListDataMaskingEncryptionAlgorithmsResponseBodyAlgorithms : TeaModel {
            /// <summary>
            /// <para>The business error code for the record or operation. This parameter can be empty when no error occurs. Evaluate this parameter together with ErrorMessage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_masking_not_running</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The business error message for the record or operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance is not in the running state</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The name of the algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AES_256_GCM</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which can be used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
