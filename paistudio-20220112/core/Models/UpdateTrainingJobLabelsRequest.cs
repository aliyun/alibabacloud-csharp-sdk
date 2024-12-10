// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UpdateTrainingJobLabelsRequest : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateTrainingJobLabelsRequestLabels> Labels { get; set; }
        public class UpdateTrainingJobLabelsRequestLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RootModelID</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model-ad8cv770kl</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
