// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSAttackIntelligentProtectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("AiMode")]
        [Validation(Required=false)]
        public string AiMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>level60</para>
        /// </summary>
        [NameInMap("AiTemplate")]
        [Validation(Required=false)]
        public string AiTemplate { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-3C82-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
