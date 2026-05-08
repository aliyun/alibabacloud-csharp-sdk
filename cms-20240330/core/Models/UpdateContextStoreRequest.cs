// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateContextStoreRequest : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateContextStoreRequestConfig Config { get; set; }
        public class UpdateContextStoreRequestConfig : TeaModel {
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigSource Source { get; set; }
            public class UpdateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sls-test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sls-test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1776824891000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        [NameInMap("dataset")]
        [Validation(Required=false)]
        public UpdateContextStoreRequestDataset Dataset { get; set; }
        public class UpdateContextStoreRequestDataset : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test_dataset</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
