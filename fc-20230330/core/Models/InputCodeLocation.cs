// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InputCodeLocation : TeaModel {
        /// <summary>
        /// <para>The CRC-64 value of the function code package. If checksum is provided, Function Compute checks whether the checksum of the code package is the same as that provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2825179536350****</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket where the ZIP package of the function code is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-bucket</para>
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The name of the OSS object where the ZIP package of the function code is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-object</para>
        /// </summary>
        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The ZIP package of the function code that is encoded in Base64 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UEsDBAoAAAAAANF</para>
        /// </summary>
        [NameInMap("zipFile")]
        [Validation(Required=false)]
        public string ZipFile { get; set; }

    }

}
