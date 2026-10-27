// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of the files to be processed.</para>
        /// <remarks>
        /// <h2>You can call the <a href="~~ListAgentlessMaliciousFiles~~">ListAgentlessMaliciousFiles</a> operation to obtain the IDs.</h2>
        /// </remarks>
        /// </summary>
        [NameInMap("FileIdList")]
        [Validation(Required=false)]
        public List<long?> FileIdList { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>addWhitelist: Adds the security alerts to the whitelist.</description></item>
        /// <item><description>offWhitelist: Removes the security alerts from the whitelist.</description></item>
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
