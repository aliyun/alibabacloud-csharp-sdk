// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class SaveCrowdDatasetAndBindingDatasetRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public SaveCrowdDatasetAndBindingDatasetRequestBody Body { get; set; }
        public class SaveCrowdDatasetAndBindingDatasetRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("datasetIds")]
            [Validation(Required=false)]
            public List<string> DatasetIds { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
