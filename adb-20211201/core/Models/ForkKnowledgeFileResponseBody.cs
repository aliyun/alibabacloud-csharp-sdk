// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ForkKnowledgeFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ForkKnowledgeFileResponseBodyData Data { get; set; }
        public class ForkKnowledgeFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the newly created reference record, represented as a decimal string. Use this ID for subsequent management of the record. This parameter is returned only when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The address of the new reference record, in the format of fork://<source file ID>/<new file ID>. This parameter is returned only when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fork://123/456</para>
            /// </summary>
            [NameInMap("FileLocation")]
            [Validation(Required=false)]
            public string FileLocation { get; set; }

            /// <summary>
            /// <para>The description of the operation result. If the business operation fails, this parameter indicates the cause or the security error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fork succeeded</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the content host file, represented as a decimal string. Currently, this value is the same as the source file ID. This parameter is returned only when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OwnerFileId")]
            [Validation(Required=false)]
            public string OwnerFileId { get; set; }

            /// <summary>
            /// <para>The status of the new reference record. The value is fixed to DUPLICATED. This parameter is returned only when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DUPLICATED</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <para>The ID of the source file, represented as a decimal string. This parameter is returned only when the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SourceFileId")]
            [Validation(Required=false)]
            public string SourceFileId { get; set; }

            /// <summary>
            /// <para>Indicates whether the business operation is successful. If the operation fails, the Data parameter contains only Success and Message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
