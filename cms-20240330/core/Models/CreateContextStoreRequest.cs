// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateContextStoreRequestConfig Config { get; set; }
        public class CreateContextStoreRequestConfig : TeaModel {
            /// <summary>
            /// <para>The metadata fields.</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>The configuration source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigSource Source { get; set; }
            public class CreateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <para>The name of the Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-test-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-test-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The effective start time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1751508233000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the context store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>The type of the context store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The properties of the dataset.</para>
        /// </summary>
        [NameInMap("dataset")]
        [Validation(Required=false)]
        public CreateContextStoreRequestDataset Dataset { get; set; }
        public class CreateContextStoreRequestDataset : TeaModel {
            /// <summary>
            /// <para>The name of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_dataset</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description of the context store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
