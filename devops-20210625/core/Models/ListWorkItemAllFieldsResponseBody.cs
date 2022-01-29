// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemAllFieldsResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 字段信息
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<ListWorkItemAllFieldsResponseBodyFields> Fields { get; set; }
        public class ListWorkItemAllFieldsResponseBodyFields : TeaModel {
            /// <summary>
            /// 字段类型
            /// </summary>
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// 创建人id
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 默认值
            /// </summary>
            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// 描述信息
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 字段格式
            /// </summary>
            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 字段唯一标识符
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 是否必填
            /// </summary>
            [NameInMap("isRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// 创建时是否展示
            /// </summary>
            [NameInMap("isShowWhenCreate")]
            [Validation(Required=false)]
            public bool? IsShowWhenCreate { get; set; }

            /// <summary>
            /// 是否是系统必须字段，比如：负责人、状态等。
            /// </summary>
            [NameInMap("isSystemRequired")]
            [Validation(Required=false)]
            public bool? IsSystemRequired { get; set; }

            /// <summary>
            /// 联动的服务，比如：迭代 迭代服务开启/关闭，这个字段字段加进/剔除出对应的模板； 字段模板里，这类字段不能手动添加或删除
            /// </summary>
            [NameInMap("linkWithService")]
            [Validation(Required=false)]
            public string LinkWithService { get; set; }

            /// <summary>
            /// 修改人
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 字段名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 待选值
            /// </summary>
            [NameInMap("options")]
            [Validation(Required=false)]
            public List<ListWorkItemAllFieldsResponseBodyFieldsOptions> Options { get; set; }
            public class ListWorkItemAllFieldsResponseBodyFieldsOptions : TeaModel {
                /// <summary>
                /// 根据语言环境获取当前展示的值
                /// </summary>
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                /// <summary>
                /// 字段唯一标识
                /// </summary>
                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                /// <summary>
                /// 待选值的唯一标识
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// 展示级别，数字范围1~9，数字越大，颜色越浅。
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// 待选值顺序
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// 待选值中文名称
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// 待选值英文名称
                /// </summary>
                [NameInMap("valueEn")]
                [Validation(Required=false)]
                public string ValueEn { get; set; }

            }

            /// <summary>
            /// 区分不同的适用对象
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// 区分不同的类型，如系统字段、用户自定义字段
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
