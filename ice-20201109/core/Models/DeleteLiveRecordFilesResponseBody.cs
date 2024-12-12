// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveRecordFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of files deleted.</para>
        /// </summary>
        [NameInMap("DeleteFileInfoList")]
        [Validation(Required=false)]
        public List<DeleteLiveRecordFilesResponseBodyDeleteFileInfoList> DeleteFileInfoList { get; set; }
        public class DeleteLiveRecordFilesResponseBodyDeleteFileInfoList : TeaModel {
            /// <summary>
            /// <para>The code that identifies the result of the deletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The result of deletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the deleted recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13cbb83e-043c-4728-ac35-*****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

        }

        /// <summary>
        /// <para>The description of the state returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>13cbb83e-043c-4728-ac35-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
