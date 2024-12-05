// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexVersionRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ModifyIndexVersionRequestBody> Body { get; set; }
        public class ModifyIndexVersionRequestBody : TeaModel {
            /// <summary>
            /// <para>The deployment ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>277</para>
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public string BuildDeployId { get; set; }

            /// <summary>
            /// <para>The index name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main_index</para>
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// <para>The index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
