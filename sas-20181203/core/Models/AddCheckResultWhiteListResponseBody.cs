// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCheckResultWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDs of the whitelist rules that are generated.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<long?> RuleIds { get; set; }

    }

}
