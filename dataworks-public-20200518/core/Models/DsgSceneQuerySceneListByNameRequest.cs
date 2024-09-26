// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data masking scenario. A fuzzy match is performed in the platform based on a keyword to search for the data masking scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

    }

}
