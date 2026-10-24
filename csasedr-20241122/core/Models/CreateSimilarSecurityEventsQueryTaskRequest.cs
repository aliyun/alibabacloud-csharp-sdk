// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class CreateSimilarSecurityEventsQueryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14323</para>
        /// </summary>
        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public long? SecurityEventId { get; set; }

        /// <summary>
        /// <para>The scenario code of alerting events that are of the same type or have the same rule hits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SimilarEventScenarioCode")]
        [Validation(Required=false)]
        public string SimilarEventScenarioCode { get; set; }

    }

}
