// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The file identifier. Only MD5 is supported. You can specify up to 100 elements in the list.</para>
        /// <remarks>
        /// <para><b>HashKeyList</b> and <b>HashKeyContextList</b> cannot be empty at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HashKeyContextList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlRequestHashKeyContextList> HashKeyContextList { get; set; }
        public class CreateFileDetectUploadUrlRequestHashKeyContextList : TeaModel {
            /// <summary>
            /// <para>The file size. If the file size exceeds the limit, the upload parameters are not returned. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2698557</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>The file hash value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30319dd5cee8f894766e479cac170da0</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the file. You can specify up to 100 elements in the list.</para>
        /// <remarks>
        /// <para><b>HashKeyList</b> and <b>HashKeyContextList</b> cannot be empty at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateFileDetectUploadUrl</para>
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// <para>The file type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Uncertain file type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
