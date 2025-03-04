// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class BindConfigGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0chlk9b65lj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E54EB497-D7B7-5F04-B744-D8DFA7B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
