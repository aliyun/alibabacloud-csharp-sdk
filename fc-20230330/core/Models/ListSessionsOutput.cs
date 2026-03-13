// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListSessionsOutput : TeaModel {
        /// <summary>
        /// <para>The starting position for the next session list query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNCNhYmM=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of sessions.</para>
        /// </summary>
        [NameInMap("sessions")]
        [Validation(Required=false)]
        public List<Session> Sessions { get; set; }

    }

}
