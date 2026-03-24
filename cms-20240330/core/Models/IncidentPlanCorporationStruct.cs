// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanCorporationStruct : TeaModel {
        /// <summary>
        /// <para>通道名</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>机器人唯一ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>robotId-cs-api-test</para>
        /// </summary>
        [NameInMap("robotId")]
        [Validation(Required=false)]
        public string RobotId { get; set; }

    }

}
