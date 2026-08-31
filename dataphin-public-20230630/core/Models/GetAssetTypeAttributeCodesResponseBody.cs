// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetTypeAttributeCodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of property definitions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAssetTypeAttributeCodesResponseBodyData> Data { get; set; }
        public class GetAssetTypeAttributeCodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The property code (unique identifier).</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_level</para>
            /// </summary>
            [NameInMap("AttributeCode")]
            [Validation(Required=false)]
            public string AttributeCode { get; set; }

            /// <summary>
            /// <para>The property name (display name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data level</para>
            /// </summary>
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }

            /// <summary>
            /// <para>The property source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system preset.</description></item>
            /// <item><description>CUSTOM: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("AttributeSource")]
            [Validation(Required=false)]
            public string AttributeSource { get; set; }

            /// <summary>
            /// <para>The property type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MANAGEMENT: management property.</description></item>
            /// <item><description>TECHNICAL: technical property.</description></item>
            /// <item><description>BUSINESS: business property.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGEMENT</para>
            /// </summary>
            [NameInMap("AttributeType")]
            [Validation(Required=false)]
            public string AttributeType { get; set; }

            /// <summary>
            /// <para>The property description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data asset level classification</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The location where the property can be edited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASSET: asset catalog.</description></item>
            /// <item><description>DEVELOPMENT: development.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("EditableIn")]
            [Validation(Required=false)]
            public List<string> EditableIn { get; set; }

            /// <summary>
            /// <para>The source of dropdown options. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MANUAL: manual input.</description></item>
            /// <item><description>SYSTEM_REFERENCE: reference to a system property.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("EnumSourceType")]
            [Validation(Required=false)]
            public string EnumSourceType { get; set; }

            /// <summary>
            /// <para>The list of dropdown options. This parameter has a value only when EnumSourceType is set to MANUAL.</para>
            /// </summary>
            [NameInMap("EnumValues")]
            [Validation(Required=false)]
            public List<GetAssetTypeAttributeCodesResponseBodyDataEnumValues> EnumValues { get; set; }
            public class GetAssetTypeAttributeCodesResponseBodyDataEnumValues : TeaModel {
                /// <summary>
                /// <para>The display name of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The option value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The input mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CUSTOM_INPUT: custom input.</description></item>
            /// <item><description>DROPDOWN_SINGLE: single-select dropdown.</description></item>
            /// <item><description>DROPDOWN_MULTI: multi-select dropdown.</description></item>
            /// <item><description>HYPERLINK: hyperlink.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DROPDOWN_SINGLE</para>
            /// </summary>
            [NameInMap("InputMode")]
            [Validation(Required=false)]
            public string InputMode { get; set; }

            /// <summary>
            /// <para>The hyperlink navigation method. This parameter has a value only when InputMode is set to HYPERLINK. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CURRENT_PAGE: opens in the current page.</description></item>
            /// <item><description>NEW_PAGE: opens in a new page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NEW_PAGE</para>
            /// </summary>
            [NameInMap("LinkTarget")]
            [Validation(Required=false)]
            public string LinkTarget { get; set; }

            /// <summary>
            /// <para>The maximum length. This parameter is valid only when ValueType is set to STRING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            /// <summary>
            /// <para>Indicates whether the property is required.</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>The type of the referenced system property. This parameter has a value only when EnumSourceType is set to SYSTEM_REFERENCE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("SystemReferenceType")]
            [Validation(Required=false)]
            public string SystemReferenceType { get; set; }

            /// <summary>
            /// <para>The data type of the property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

            /// <summary>
            /// <para>The location where the property is visible. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASSET: asset catalog.</description></item>
            /// <item><description>DEVELOPMENT: development.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("VisibleIn")]
            [Validation(Required=false)]
            public List<string> VisibleIn { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
