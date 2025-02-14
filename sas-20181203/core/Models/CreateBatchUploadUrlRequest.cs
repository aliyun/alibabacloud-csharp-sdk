// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateBatchUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The identifiers of files. Only MD5 hash values are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Md5List")]
        [Validation(Required=false)]
        public List<string> Md5List { get; set; }

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
