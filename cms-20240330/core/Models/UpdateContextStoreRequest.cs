// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateContextStoreRequestConfig Config { get; set; }
        public class UpdateContextStoreRequestConfig : TeaModel {
            /// <summary>
            /// <para>The metadata field.</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>The data source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigSource Source { get; set; }
            public class UpdateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <para>The Log Service Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The Log Service Project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1776824891000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The context type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The dataset.</para>
        /// </summary>
        [NameInMap("dataset")]
        [Validation(Required=false)]
        public UpdateContextStoreRequestDataset Dataset { get; set; }
        public class UpdateContextStoreRequestDataset : TeaModel {
            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_dataset</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
