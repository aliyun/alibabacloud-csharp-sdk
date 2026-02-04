// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateNormalizationSchemaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NormalizationFields")]
        [Validation(Required=false)]
        public List<UpdateNormalizationSchemaRequestNormalizationFields> NormalizationFields { get; set; }
        public class UpdateNormalizationSchemaRequestNormalizationFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_user</para>
            /// </summary>
            [NameInMap("NormalizationFieldDescription")]
            [Validation(Required=false)]
            public string NormalizationFieldDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173326*******</para>
            /// </summary>
            [NameInMap("NormalizationFieldExample")]
            [Validation(Required=false)]
            public string NormalizationFieldExample { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationFieldFrom")]
            [Validation(Required=false)]
            public string NormalizationFieldFrom { get; set; }

            [NameInMap("NormalizationFieldJsonIndexAll")]
            [Validation(Required=false)]
            public bool? NormalizationFieldJsonIndexAll { get; set; }

            [NameInMap("NormalizationFieldJsonKeys")]
            [Validation(Required=false)]
            public List<UpdateNormalizationSchemaRequestNormalizationFieldsNormalizationFieldJsonKeys> NormalizationFieldJsonKeys { get; set; }
            public class UpdateNormalizationSchemaRequestNormalizationFieldsNormalizationFieldJsonKeys : TeaModel {
                [NameInMap("NormalizationFieldDescription")]
                [Validation(Required=false)]
                public string NormalizationFieldDescription { get; set; }

                [NameInMap("NormalizationFieldExample")]
                [Validation(Required=false)]
                public string NormalizationFieldExample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>preset</para>
                /// </summary>
                [NameInMap("NormalizationFieldFrom")]
                [Validation(Required=false)]
                public string NormalizationFieldFrom { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alert_name</para>
                /// </summary>
                [NameInMap("NormalizationFieldName")]
                [Validation(Required=false)]
                public string NormalizationFieldName { get; set; }

                [NameInMap("NormalizationFieldRequired")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NormalizationFieldTokenize")]
                [Validation(Required=false)]
                public bool? NormalizationFieldTokenize { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_user</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            [NameInMap("NormalizationFieldTokenize")]
            [Validation(Required=false)]
            public bool? NormalizationFieldTokenize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProcessQuery</para>
        /// </summary>
        [NameInMap("NormalizationSchemaDescription")]
        [Validation(Required=false)]
        public string NormalizationSchemaDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF_ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProcessQuery</para>
        /// </summary>
        [NameInMap("NormalizationSchemaName")]
        [Validation(Required=false)]
        public string NormalizationSchemaName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("NormalizationSchemaType")]
        [Validation(Required=false)]
        public string NormalizationSchemaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
