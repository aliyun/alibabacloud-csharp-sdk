// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeCtrlInstanceMemberAccountsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InstanceMemberCount")]
        [Validation(Required=false)]
        public long? InstanceMemberCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxInstanceMemberNum")]
        [Validation(Required=false)]
        public long? MaxInstanceMemberNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9CC69FDA-69F6-585B-9262-A306F425****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
