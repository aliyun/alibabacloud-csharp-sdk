// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B23A612-D997-5176-8C3B-D640DFD65772</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the whitelist.</para>
        /// </summary>
        [NameInMap("VulWhitelistList")]
        [Validation(Required=false)]
        public List<ModifyCreateVulWhitelistResponseBodyVulWhitelistList> VulWhitelistList { get; set; }
        public class ModifyCreateVulWhitelistResponseBodyVulWhitelistList : TeaModel {
            /// <summary>
            /// <para>The ID of the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30376</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
