// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether a next query token exists. You do not need to specify this parameter for the first query or if no next query exists. If a next query exists, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of normalization fields.</para>
        /// </summary>
        [NameInMap("NormalizationFields")]
        [Validation(Required=false)]
        public List<ListNormalizationFieldsResponseBodyNormalizationFields> NormalizationFields { get; set; }
        public class ListNormalizationFieldsResponseBodyNormalizationFields : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1736386610000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the normalization category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <para>The description of the normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_user</para>
            /// </summary>
            [NameInMap("NormalizationFieldDescription")]
            [Validation(Required=false)]
            public string NormalizationFieldDescription { get; set; }

            /// <summary>
            /// <para>The example value of the normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173326*******</para>
            /// </summary>
            [NameInMap("NormalizationFieldExample")]
            [Validation(Required=false)]
            public string NormalizationFieldExample { get; set; }

            /// <summary>
            /// <para>The source of the normalization field key of the JSON type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationFieldFrom")]
            [Validation(Required=false)]
            public string NormalizationFieldFrom { get; set; }

            /// <summary>
            /// <para>Indicates whether indexes are created for all keys of the JSON-type normalization field.</para>
            /// </summary>
            [NameInMap("NormalizationFieldJsonIndexAll")]
            [Validation(Required=false)]
            public bool? NormalizationFieldJsonIndexAll { get; set; }

            /// <summary>
            /// <para>The list of keys for the JSON-type normalization field.</para>
            /// </summary>
            [NameInMap("NormalizationFieldJsonKeys")]
            [Validation(Required=false)]
            public List<ListNormalizationFieldsResponseBodyNormalizationFieldsNormalizationFieldJsonKeys> NormalizationFieldJsonKeys { get; set; }
            public class ListNormalizationFieldsResponseBodyNormalizationFieldsNormalizationFieldJsonKeys : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the JSON-type normalization field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert_level</para>
                /// </summary>
                [NameInMap("NormalizationFieldDescription")]
                [Validation(Required=false)]
                public string NormalizationFieldDescription { get; set; }

                /// <summary>
                /// <para>The example value of the JSON-type normalization field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NormalizationFieldExample")]
                [Validation(Required=false)]
                public string NormalizationFieldExample { get; set; }

                /// <summary>
                /// <para>The source of the normalization field key of the JSON type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>preset</para>
                /// </summary>
                [NameInMap("NormalizationFieldFrom")]
                [Validation(Required=false)]
                public string NormalizationFieldFrom { get; set; }

                /// <summary>
                /// <para>The name of the JSON-type normalization field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert_level</para>
                /// </summary>
                [NameInMap("NormalizationFieldName")]
                [Validation(Required=false)]
                public string NormalizationFieldName { get; set; }

                /// <summary>
                /// <para>Indicates whether the JSON-type normalization field key is required.</para>
                /// </summary>
                [NameInMap("NormalizationFieldRequired")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequired { get; set; }

                /// <summary>
                /// <para>Indicates whether the normalization field key is a built-in system field key.</para>
                /// </summary>
                [NameInMap("NormalizationFieldReserved")]
                [Validation(Required=false)]
                public bool? NormalizationFieldReserved { get; set; }

                /// <summary>
                /// <para>Indicates whether the JSON-type normalization field key is tokenized.</para>
                /// </summary>
                [NameInMap("NormalizationFieldTokenize")]
                [Validation(Required=false)]
                public bool? NormalizationFieldTokenize { get; set; }

                /// <summary>
                /// <para>The type of the JSON-type normalization field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("NormalizationFieldType")]
                [Validation(Required=false)]
                public string NormalizationFieldType { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_user</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            /// <summary>
            /// <para>Indicates whether the normalization field key is required.</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the normalization field is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequirement")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequirement { get; set; }

            /// <summary>
            /// <para>Indicates whether the normalization field is reserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <para>Indicates whether the normalization field is tokenized.</para>
            /// </summary>
            [NameInMap("NormalizationFieldTokenize")]
            [Validation(Required=false)]
            public bool? NormalizationFieldTokenize { get; set; }

            /// <summary>
            /// <para>The type of the normalization field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>varchar</description></item>
            /// <item><description>bigint</description></item>
            /// <item><description>double.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

            /// <summary>
            /// <para>The ID of the normalization schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_SESSION_ACTIVITY</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_AND_WEB_SECURITY</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainId")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainId { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1736386610000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
