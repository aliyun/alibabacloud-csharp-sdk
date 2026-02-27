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
        /// <para>Vulnerability whitelist information. 
        /// <notice> This data is not returned when adding or updating the vulnerability whitelist in batches, it is only returned when adding or updating a single vulnerability whitelist entry. </notice></para>
        /// </summary>
        [NameInMap("VulWhitelistList")]
        [Validation(Required=false)]
        public ModifyCreateVulWhitelistResponseBodyVulWhitelistList VulWhitelistList { get; set; }
        public class ModifyCreateVulWhitelistResponseBodyVulWhitelistList : TeaModel {
            /// <summary>
            /// <para>Vulnerability whitelist ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
