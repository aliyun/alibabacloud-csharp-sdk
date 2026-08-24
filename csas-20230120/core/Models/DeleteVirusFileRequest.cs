// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteVirusFileRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the user\&quot;s endpoint device where the virus file is located. The value can be up to 64 characters in length. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The MD5 value of the virus file. The value must be a 32-character hexadecimal string. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The full path of the virus file on the user\&quot;s endpoint device. Only records with a handling action of Fail can be deleted. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusFileStatuses~~">ListVirusFileStatuses</a>: lists virus file statuses.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C:\Users\Public\Downloads\setup.exe</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
