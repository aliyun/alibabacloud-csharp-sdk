// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanCorporationStruct : TeaModel {
        /// <summary>
        /// <para>The channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The unique ID of the robot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>robotId-cs-api-test</para>
        /// </summary>
        [NameInMap("robotId")]
        [Validation(Required=false)]
        public string RobotId { get; set; }

    }

}
