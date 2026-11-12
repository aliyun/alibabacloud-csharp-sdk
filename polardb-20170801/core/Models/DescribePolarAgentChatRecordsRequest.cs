// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarAgentChatRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The session ID. To obtain the SessionId, use Signature Version 3.0 to call GetPolarAgent to initiate a conversation and extract the SessionId from the returned stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44dcdf31-04cd-4a44-9bae-834dd6657e29</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The product type source. Valid value: polardb-console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb-console</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
