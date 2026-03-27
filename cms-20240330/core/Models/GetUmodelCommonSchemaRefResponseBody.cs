// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetUmodelCommonSchemaRefResponseBody : TeaModel {
        [NameInMap("commonSchemaRef")]
        [Validation(Required=false)]
        public List<GetUmodelCommonSchemaRefResponseBodyCommonSchemaRef> CommonSchemaRef { get; set; }
        public class GetUmodelCommonSchemaRefResponseBodyCommonSchemaRef : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>apm-common</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
