// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateSystemPropertyTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAuto")]
        [Validation(Required=false)]
        public bool? EnableAuto { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://filepath****.com">https://filepath****.com</a></para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("SystemPropertyInfo")]
        [Validation(Required=false)]
        public CreateSystemPropertyTemplateRequestSystemPropertyInfo SystemPropertyInfo { get; set; }
        public class CreateSystemPropertyTemplateRequestSystemPropertyInfo : TeaModel {
            [NameInMap("CustomPropertyInfos")]
            [Validation(Required=false)]
            public List<CreateSystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos> CustomPropertyInfos { get; set; }
            public class CreateSystemPropertyTemplateRequestSystemPropertyInfoCustomPropertyInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>propKey</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>propValue</para>
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBootloader")]
            [Validation(Required=false)]
            public string RoBootloader { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildDisplayId")]
            [Validation(Required=false)]
            public string RoBuildDisplayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildFingerprint")]
            [Validation(Required=false)]
            public string RoBuildFingerprint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildHost")]
            [Validation(Required=false)]
            public string RoBuildHost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildId")]
            [Validation(Required=false)]
            public string RoBuildId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildProduct")]
            [Validation(Required=false)]
            public string RoBuildProduct { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildTags")]
            [Validation(Required=false)]
            public string RoBuildTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildType")]
            [Validation(Required=false)]
            public string RoBuildType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoBuildUser")]
            [Validation(Required=false)]
            public string RoBuildUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductBoard")]
            [Validation(Required=false)]
            public string RoProductBoard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductBrand")]
            [Validation(Required=false)]
            public string RoProductBrand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductDevice")]
            [Validation(Required=false)]
            public string RoProductDevice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductManufacturer")]
            [Validation(Required=false)]
            public string RoProductManufacturer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoProductModel")]
            [Validation(Required=false)]
            public string RoProductModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RwRoSerialNo")]
            [Validation(Required=false)]
            public string RwRoSerialNo { get; set; }

        }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
