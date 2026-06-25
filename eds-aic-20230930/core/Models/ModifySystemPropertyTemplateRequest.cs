// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifySystemPropertyTemplateRequest : TeaModel {
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
        /// <para>The URL of the property template file. The system synchronously parses the file. If the file format is invalid, a parsing error is returned.</para>
        /// <remarks>
        /// <para>File template format: <c>{ &quot;properties&quot;:{&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;:&quot;value2&quot;}}</c>.</para>
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
        public ModifySystemPropertyTemplateRequestSystemPropertyInfo SystemPropertyInfo { get; set; }
        public class ModifySystemPropertyTemplateRequestSystemPropertyInfo : TeaModel {
            /// <summary>
            /// <para>The information about custom properties.</para>
            /// </summary>
            [NameInMap("CustomPropertyInfos")]
            [Validation(Required=false)]
            public List<ModifySystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos> CustomPropertyInfos { get; set; }
            public class ModifySystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos : TeaModel {
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
            /// <para>This parameter is not publicly available.</para>
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
        /// <para>The ID of the property template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-angyvganxlf****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template 1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
