// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EmbeddingTransformParameters : TeaModel {
        /// <summary>
        /// <para>The API key used to call the Model Studio embedding model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Q37sQ****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The input data to be vectorized and its transformation method.</para>
        /// </summary>
        [NameInMap("EmbeddingData")]
        [Validation(Required=false)]
        public EmbeddingTransformParametersEmbeddingData EmbeddingData { get; set; }
        public class EmbeddingTransformParametersEmbeddingData : TeaModel {
            /// <summary>
            /// <para>The method used to generate the input data. JSONPATH indicates that data is extracted from the event by using JSONPath.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template used to build the input data. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the input data. If Form is set to JSONPATH, specify a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.message</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the model used to generate embeddings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v3</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

    }

}
