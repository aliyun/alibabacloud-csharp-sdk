// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ContentSyncDetectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>textDetection</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("serviceParameter")]
        [Validation(Required=false)]
        public ContentSyncDetectRequestServiceParameter ServiceParameter { get; set; }
        public class ContentSyncDetectRequestServiceParameter : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
