// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateNormalizationSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Note: This parameter is required in actual API calls. If it is not provided, the service returns a 400 error &quot;The specified Lang can not be empty.&quot;. Explicitly pass the language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        /// <para>The source of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>native</para>
        /// </summary>
        [NameInMap("NormalizationFieldSource")]
        [Validation(Required=false)]
        public string NormalizationFieldSource { get; set; }

        /// <summary>
        /// <para>The normalization fields.</para>
        /// </summary>
        [NameInMap("NormalizationFields")]
        [Validation(Required=false)]
        public List<CreateNormalizationSchemaRequestNormalizationFields> NormalizationFields { get; set; }
        public class CreateNormalizationSchemaRequestNormalizationFields : TeaModel {
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
            /// <para>The example of the normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173326*******</para>
            /// </summary>
            [NameInMap("NormalizationFieldExample")]
            [Validation(Required=false)]
            public string NormalizationFieldExample { get; set; }

            /// <summary>
            /// <para>The source of the key for the JSON normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationFieldFrom")]
            [Validation(Required=false)]
            public string NormalizationFieldFrom { get; set; }

            /// <summary>
            /// <para>Specifies whether to create indexes for all keys of the JSON normalization field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldJsonIndexAll")]
            [Validation(Required=false)]
            public bool? NormalizationFieldJsonIndexAll { get; set; }

            /// <summary>
            /// <para>The list of keys for the JSON normalization field.</para>
            /// </summary>
            [NameInMap("NormalizationFieldJsonKeys")]
            [Validation(Required=false)]
            public List<CreateNormalizationSchemaRequestNormalizationFieldsNormalizationFieldJsonKeys> NormalizationFieldJsonKeys { get; set; }
            public class CreateNormalizationSchemaRequestNormalizationFieldsNormalizationFieldJsonKeys : TeaModel {
                /// <summary>
                /// <para>The description of the key for the JSON normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The alert severity levels are represented by the values 1, 2, 3, and 4.</para>
                /// </summary>
                [NameInMap("NormalizationFieldDescription")]
                [Validation(Required=false)]
                public string NormalizationFieldDescription { get; set; }

                /// <summary>
                /// <para>The example of the key for the JSON normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1, 2, 3, 4</para>
                /// </summary>
                [NameInMap("NormalizationFieldExample")]
                [Validation(Required=false)]
                public string NormalizationFieldExample { get; set; }

                /// <summary>
                /// <para>The source of the key for the JSON normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>preset</para>
                /// </summary>
                [NameInMap("NormalizationFieldFrom")]
                [Validation(Required=false)]
                public string NormalizationFieldFrom { get; set; }

                /// <summary>
                /// <para>The name of the key for the JSON normalization field.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert_level</para>
                /// </summary>
                [NameInMap("NormalizationFieldName")]
                [Validation(Required=false)]
                public string NormalizationFieldName { get; set; }

                /// <summary>
                /// <para>Specifies whether the key for the JSON normalization field is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NormalizationFieldRequired")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequired { get; set; }

                /// <summary>
                /// <para>Specifies whether the key for the JSON normalization field is tokenized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NormalizationFieldTokenize")]
                [Validation(Required=false)]
                public bool? NormalizationFieldTokenize { get; set; }

                /// <summary>
                /// <para>The type of the key for the JSON normalization field. Valid values: text, long, double, and json.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("NormalizationFieldType")]
                [Validation(Required=false)]
                public string NormalizationFieldType { get; set; }

            }

            /// <summary>
            /// <para>The name of the normalization field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_user</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalization field is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalization field is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequirement")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequirement { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalization field is reserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalization field is tokenized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldTokenize")]
            [Validation(Required=false)]
            public bool? NormalizationFieldTokenize { get; set; }

            /// <summary>
            /// <para>The type of the normalization field. Valid values: text, long, double, and json.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

        }

        /// <summary>
        /// <para>The description of the normalization schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessQuery</para>
        /// </summary>
        [NameInMap("NormalizationSchemaDescription")]
        [Validation(Required=false)]
        public string NormalizationSchemaDescription { get; set; }

        /// <summary>
        /// <para>The ID of the normalization schema. When you create a custom schema, the ID must start with custom- and can contain only lowercase letters, digits, and hyphens. Example: custom-my-log-schema.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESS_QUERY_DNS_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>The name of the normalization schema.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessQuery</para>
        /// </summary>
        [NameInMap("NormalizationSchemaName")]
        [Validation(Required=false)]
        public string NormalizationSchemaName { get; set; }

        /// <summary>
        /// <para>The type of the normalization schema. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>log: Log.</description></item>
        /// <item><description>entity: Entity.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("NormalizationSchemaType")]
        [Validation(Required=false)]
        public string NormalizationSchemaType { get; set; }

        /// <summary>
        /// <para>The ID of the security domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_AND_WEB_SECURITY</para>
        /// </summary>
        [NameInMap("NormalizationSecurityDomainId")]
        [Validation(Required=false)]
        public string NormalizationSecurityDomainId { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. You must select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets are located in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The Logstore of Simple Log Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-activity</para>
        /// </summary>
        [NameInMap("TargetLogStore")]
        [Validation(Required=false)]
        public string TargetLogStore { get; set; }

        /// <summary>
        /// <para>The ID of the vendor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
