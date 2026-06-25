// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateSystemPropertyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically generate preset system properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAuto")]
        [Validation(Required=false)]
        public bool? EnableAuto { get; set; }

        /// <summary>
        /// <para>The URL of the property template file. The API parses the file synchronously. An error is returned if the file format is invalid.</para>
        /// <remarks>
        /// <para>The file must be in the following format: <c>{ &quot;properties&quot;:{&quot;key1&quot;:&quot;value1&quot;}}</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://filepath****.com">https://filepath****.com</a></para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The information about the system property template.</para>
        /// </summary>
        [NameInMap("SystemPropertyInfo")]
        [Validation(Required=false)]
        public CreateSystemPropertyTemplateRequestSystemPropertyInfo SystemPropertyInfo { get; set; }
        public class CreateSystemPropertyTemplateRequestSystemPropertyInfo : TeaModel {
            /// <summary>
            /// <para>A list of custom properties.</para>
            /// </summary>
            [NameInMap("CustomPropertyInfos")]
            [Validation(Required=false)]
            public List<CreateSystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos> CustomPropertyInfos { get; set; }
            public class CreateSystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos : TeaModel {
                /// <summary>
                /// <para>The key of the custom property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>propKey</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <para>The value of the custom property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>propValue</para>
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBootloader")]
            [Validation(Required=false)]
            public string RoBootloader { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildDisplayId")]
            [Validation(Required=false)]
            public string RoBuildDisplayId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildFingerprint")]
            [Validation(Required=false)]
            public string RoBuildFingerprint { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildHost")]
            [Validation(Required=false)]
            public string RoBuildHost { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildId")]
            [Validation(Required=false)]
            public string RoBuildId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildProduct")]
            [Validation(Required=false)]
            public string RoBuildProduct { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildTags")]
            [Validation(Required=false)]
            public string RoBuildTags { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildType")]
            [Validation(Required=false)]
            public string RoBuildType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildUser")]
            [Validation(Required=false)]
            public string RoBuildUser { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductBoard")]
            [Validation(Required=false)]
            public string RoProductBoard { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductBrand")]
            [Validation(Required=false)]
            public string RoProductBrand { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductDevice")]
            [Validation(Required=false)]
            public string RoProductDevice { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductManufacturer")]
            [Validation(Required=false)]
            public string RoProductManufacturer { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductModel")]
            [Validation(Required=false)]
            public string RoProductModel { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not yet available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RwRoSerialNo")]
            [Validation(Required=false)]
            public string RwRoSerialNo { get; set; }

        }

        /// <summary>
        /// <para>The name of the template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Be 2 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Start with an uppercase or lowercase letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>Contain letters, digits, colons (:), underscores (_), and hyphens (-). Periods (.) are not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Template1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
