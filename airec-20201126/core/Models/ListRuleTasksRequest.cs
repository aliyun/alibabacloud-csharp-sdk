// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListRuleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The completion rate of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
