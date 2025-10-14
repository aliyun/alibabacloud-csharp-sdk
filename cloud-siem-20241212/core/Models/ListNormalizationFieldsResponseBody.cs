// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationFieldsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50。</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****。</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NormalizationFields")]
        [Validation(Required=false)]
        public List<ListNormalizationFieldsResponseBodyNormalizationFields> NormalizationFields { get; set; }
        public class ListNormalizationFieldsResponseBodyNormalizationFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY。</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_user。</para>
            /// </summary>
            [NameInMap("NormalizationFieldDescription")]
            [Validation(Required=false)]
            public string NormalizationFieldDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173326*******。</para>
            /// </summary>
            [NameInMap("NormalizationFieldExample")]
            [Validation(Required=false)]
            public string NormalizationFieldExample { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_user。</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequirement")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequirement { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>varchar。</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_SESSION_ACTIVITY。</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57。</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
