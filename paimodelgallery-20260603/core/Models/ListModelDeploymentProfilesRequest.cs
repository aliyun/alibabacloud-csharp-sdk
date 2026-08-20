// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class ListModelDeploymentProfilesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cmu-biz</para>
        /// </summary>
        [NameInMap("BizKey")]
        [Validation(Required=false)]
        public string BizKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

    }

}
