// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagInfoBySelectionResponseBody : TeaModel {
        /// <summary>
        /// The response code. **OK** indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTagInfoBySelectionResponseBodyData> Data { get; set; }
        public class QueryTagInfoBySelectionResponseBodyData : TeaModel {
            /// <summary>
            /// The list of available authorization codes.
            /// </summary>
            [NameInMap("AuthCodeList")]
            [Validation(Required=false)]
            public List<string> AuthCodeList { get; set; }

            [NameInMap("ComplexityType")]
            [Validation(Required=false)]
            public string ComplexityType { get; set; }

            /// <summary>
            /// The URL for the API demo.
            /// </summary>
            [NameInMap("DemoAddress")]
            [Validation(Required=false)]
            public string DemoAddress { get; set; }

            /// <summary>
            /// The URL for the API documentation.
            /// </summary>
            [NameInMap("DocAddress")]
            [Validation(Required=false)]
            public string DocAddress { get; set; }

            /// <summary>
            /// The URL for the definitions of the enumerated values.
            /// </summary>
            [NameInMap("EnumDefinitionAddress")]
            [Validation(Required=false)]
            public string EnumDefinitionAddress { get; set; }

            /// <summary>
            /// The flow name.
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// The industry ID.
            /// </summary>
            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// The industry name.
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// The list of tag parameters.
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<QueryTagInfoBySelectionResponseBodyDataParamList> ParamList { get; set; }
            public class QueryTagInfoBySelectionResponseBodyDataParamList : TeaModel {
                /// <summary>
                /// The English name of the parameter.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The input hint.
                /// </summary>
                [NameInMap("Hint")]
                [Validation(Required=false)]
                public string Hint { get; set; }

                /// <summary>
                /// Indicates whether the parameter is required.
                /// </summary>
                [NameInMap("Must")]
                [Validation(Required=false)]
                public bool? Must { get; set; }

                /// <summary>
                /// The Chinese name of the parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type. The code that corresponds to EnumUIWidgetTypes.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The definitions of the enumerated values such as Code or Desc.
                /// </summary>
                [NameInMap("ValueDict")]
                [Validation(Required=false)]
                public List<QueryTagInfoBySelectionResponseBodyDataParamListValueDict> ValueDict { get; set; }
                public class QueryTagInfoBySelectionResponseBodyDataParamListValueDict : TeaModel {
                    /// <summary>
                    /// The English name.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The Chinese name.
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                }

            }

            [NameInMap("RichTextDescription")]
            [Validation(Required=false)]
            public string RichTextDescription { get; set; }

            /// <summary>
            /// The scene ID.
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// The scene name.
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The tag ID.
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// The tag name.
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
