// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagInfoBySelectionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTagInfoBySelectionResponseBodyData> Data { get; set; }
        public class QueryTagInfoBySelectionResponseBodyData : TeaModel {
            /// <summary>
            /// 可用的授权码列表
            /// </summary>
            [NameInMap("AuthCodeList")]
            [Validation(Required=false)]
            public List<string> AuthCodeList { get; set; }

            /// <summary>
            /// API demo链接
            /// </summary>
            [NameInMap("DemoAddress")]
            [Validation(Required=false)]
            public string DemoAddress { get; set; }

            /// <summary>
            /// API文档链接
            /// </summary>
            [NameInMap("DocAddress")]
            [Validation(Required=false)]
            public string DocAddress { get; set; }

            /// <summary>
            /// 枚举值定义链接
            /// </summary>
            [NameInMap("EnumDefinitionAddress")]
            [Validation(Required=false)]
            public string EnumDefinitionAddress { get; set; }

            /// <summary>
            /// 流程名称
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// 行业id
            /// </summary>
            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public long? IndustryId { get; set; }

            /// <summary>
            /// 行业名称
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// 标签参数列表
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<QueryTagInfoBySelectionResponseBodyDataParamList> ParamList { get; set; }
            public class QueryTagInfoBySelectionResponseBodyDataParamList : TeaModel {
                /// <summary>
                /// 参数英文名
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 输入提示
                /// </summary>
                [NameInMap("Hint")]
                [Validation(Required=false)]
                public string Hint { get; set; }

                /// <summary>
                /// 是否必填
                /// </summary>
                [NameInMap("Must")]
                [Validation(Required=false)]
                public bool? Must { get; set; }

                /// <summary>
                /// 参数中文名
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 类型EnumUIWidgetTypes对应的code
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 枚举值定义，code:desc
                /// </summary>
                [NameInMap("ValueDict")]
                [Validation(Required=false)]
                public List<QueryTagInfoBySelectionResponseBodyDataParamListValueDict> ValueDict { get; set; }
                public class QueryTagInfoBySelectionResponseBodyDataParamListValueDict : TeaModel {
                    /// <summary>
                    /// 英文名
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// 中文名
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                }

            }

            /// <summary>
            /// 场景id
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// 场景名称
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// 标签id
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// 标签名称
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
