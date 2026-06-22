// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>The list of file IDs to process.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAgentlessMaliciousFiles~~">ListAgentlessMaliciousFiles</a> to obtain the IDs.
        /// -.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FileIdList")]
        [Validation(Required=false)]
        public List<long?> FileIdList { get; set; }

        /// <summary>
        /// <para>The type of operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>addWhitelist: adds to the whitelist.</description></item>
        /// <item><description>offWhitelist: removes from the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>addWhitelist</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

    }

}
