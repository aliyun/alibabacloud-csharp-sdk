// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The hash values of files.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>HashKeyList</b> and <b>HashKeyContextList</b> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HashKeyContextList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlRequestHashKeyContextList> HashKeyContextList { get; set; }
        public class CreateFileDetectUploadUrlRequestHashKeyContextList : TeaModel {
            /// <summary>
            /// <para>The size of the file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2698557</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>The hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30319dd5cee8f894766e479cac170da0</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

        }

        /// <summary>
        /// <para>The identifiers of files. Only MD5 hash values are supported.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>HashKeyList</b> and <b>HashKeyContextList</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateFileDetectUploadUrl</para>
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// <para>The type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unknown file</description></item>
        /// <item><description><b>1</b>: binary file</description></item>
        /// <item><description><b>2</b>: webshell file</description></item>
        /// <item><description><b>4</b>: script file</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not know the type of the file, set this parameter to <b>0</b>.</para>
        /// </remarks>
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
