// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class PrivatePoolOptions : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("MatchCriteria")]
        [Validation(Required=false)]
        public string MatchCriteria { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eap-bp67acfmxazb4****</para>
        /// </summary>
        [NameInMap("PrivatePoolIds")]
        [Validation(Required=false)]
        public List<string> PrivatePoolIds { get; set; }

    }

}
