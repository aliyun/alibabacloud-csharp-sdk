// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class InstanceHealerResponseBody : TeaModel {
        [NameInMap("InstanceHealerModel")]
        [Validation(Required=false)]
        public InstanceHealerResponseBodyInstanceHealerModel InstanceHealerModel { get; set; }
        public class InstanceHealerResponseBodyInstanceHealerModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B9EFA4F-4305-5968-BAEE-BD8B8DE5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
