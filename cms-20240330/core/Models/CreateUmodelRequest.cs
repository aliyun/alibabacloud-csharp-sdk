// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateUmodelRequest : TeaModel {
        [NameInMap("commonSchemaRef")]
        [Validation(Required=false)]
        public List<CreateUmodelRequestCommonSchemaRef> CommonSchemaRef { get; set; }
        public class CreateUmodelRequestCommonSchemaRef : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-job-123</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
