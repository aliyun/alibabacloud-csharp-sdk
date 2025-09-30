// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class UpdateVideoAnalysisTasksRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CANCELED</para>
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
