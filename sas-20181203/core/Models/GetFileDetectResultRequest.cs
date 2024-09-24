// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultRequest : TeaModel {
        /// <summary>
        /// <para>The identifiers of files. Only MD5 hash values are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183.46.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unknown file</description></item>
        /// <item><description><b>1</b>: binary file</description></item>
        /// <item><description><b>2</b>: webshell file</description></item>
        /// <item><description><b>4</b>: script file</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not know the type of the file, set this parameter to 0.</para>
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
