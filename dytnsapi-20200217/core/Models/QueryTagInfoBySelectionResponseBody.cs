// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagInfoBySelectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>OK</b> indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTagInfoBySelectionResponseBodyData> Data { get; set; }
        public class QueryTagInfoBySelectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of available authorization codes.</para>
            /// </summary>
            [NameInMap("AuthCodeList")]
            [Validation(Required=false)]
            public List<string> AuthCodeList { get; set; }

            [NameInMap("ComplexityType")]
            [Validation(Required=false)]
            public string ComplexityType { get; set; }

            /// <summary>
            /// <para>The URL for the API demo.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/document_detail/388997.html?spm=a2c4g.2573870.0.0.3aa921cbOrtqJz">https://help.aliyun.com/document_detail/388997.html?spm=a2c4g.2573870.0.0.3aa921cbOrtqJz</a></para>
            /// </summary>
            [NameInMap("DemoAddress")]
            [Validation(Required=false)]
            public string DemoAddress { get; set; }

            /// <summary>
            /// <para>The URL for the API documentation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/document_detail/388997.html?spm=a2c4g.2573870.0.0.3aa921cbOrtqJz">https://help.aliyun.com/document_detail/388997.html?spm=a2c4g.2573870.0.0.3aa921cbOrtqJz</a></para>
            /// </summary>
            [NameInMap("DocAddress")]
            [Validation(Required=false)]
            public string DocAddress { get; set; }

            /// <summary>
            /// <para>The URL for the definitions of the enumerated values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("EnumDefinitionAddress")]
            [Validation(Required=false)]
            public string EnumDefinitionAddress { get; set; }

            /// <summary>
            /// <para>The flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>process name</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The industry ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// <para>The industry name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logistics</para>
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>The list of tag parameters.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<QueryTagInfoBySelectionResponseBodyDataParamList> ParamList { get; set; }
            public class QueryTagInfoBySelectionResponseBodyDataParamList : TeaModel {
                /// <summary>
                /// <para>The English name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>preame</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The input hint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Hint")]
                [Validation(Required=false)]
                public string Hint { get; set; }

                /// <summary>
                /// <para>Indicates whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Must")]
                [Validation(Required=false)]
                public bool? Must { get; set; }

                /// <summary>
                /// <para>The Chinese name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type. The code that corresponds to EnumUIWidgetTypes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aqzx</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The definitions of the enumerated values such as Code or Desc.</para>
                /// </summary>
                [NameInMap("ValueDict")]
                [Validation(Required=false)]
                public List<QueryTagInfoBySelectionResponseBodyDataParamListValueDict> ValueDict { get; set; }
                public class QueryTagInfoBySelectionResponseBodyDataParamListValueDict : TeaModel {
                    /// <summary>
                    /// <para>The English name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Aliyun</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The Chinese name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>阿里云</para>
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
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>The scene name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General scenario</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The tag ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Number ownership</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C3B8084-3A7D-570B-BC84-BF945A9CF65E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
