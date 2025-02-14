// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>List of file IDs to be processed.</para>
        /// <remarks>
        /// <h2>You can call <a href="~~ListAgentlessMaliciousFiles~~">ListAgentlessMaliciousFiles</a> to get the IDs.</h2>
        /// </remarks>
        /// </summary>
        [NameInMap("FileIdList")]
        [Validation(Required=false)]
        public List<long?> FileIdList { get; set; }

        /// <summary>
        /// <para>Type of operation:</para>
        /// <list type="bullet">
        /// <item><description>addWhitelist: Add to whitelist</description></item>
        /// <item><description>offWhitelist: Remove from whitelist</description></item>
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
