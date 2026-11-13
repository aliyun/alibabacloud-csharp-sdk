// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameRequest : TeaModel {
        /// <summary>
        /// <para>The fuzzy match keyword for the masking scenario name. The platform retrieves related masking scenario information based on this keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

    }

}
