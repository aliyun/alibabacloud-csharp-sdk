// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetInstancePropertiesResponseBody : TeaModel {
        [NameInMap("PropertyTemplateModel")]
        [Validation(Required=false)]
        public GetInstancePropertiesResponseBodyPropertyTemplateModel PropertyTemplateModel { get; set; }
        public class GetInstancePropertiesResponseBodyPropertyTemplateModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;propties&quot;:{&quot;key1&quot;:&quot;value1&quot;}}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
