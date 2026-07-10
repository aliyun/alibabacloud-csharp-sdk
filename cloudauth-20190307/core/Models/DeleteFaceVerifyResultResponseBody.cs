// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteFaceVerifyResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A6229C0-E156-48E4-B6EC-0F528BDF60D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DeleteFaceVerifyResultResponseBodyResultObject ResultObject { get; set; }
        public class DeleteFaceVerifyResultResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The unique identifier for real-person authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha58aeae7ea2f5ed069530f58df4e6d</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>The deletion result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Deletion successful.</description></item>
            /// <item><description>N: Deletion failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("DeleteResult")]
            [Validation(Required=false)]
            public string DeleteResult { get; set; }

            /// <summary>
            /// <para>The reason for deletion failure.</para>
            /// <list type="bullet">
            /// <item><description>NOT_DELETE_REPEATEDLY: The data cannot be deleted repeatedly.</description></item>
            /// <item><description>NEED_QUERY_VERIFY_RESULT: You must query the authentication result before deleting.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_DELETE_REPEATEDLY</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

    }

}
