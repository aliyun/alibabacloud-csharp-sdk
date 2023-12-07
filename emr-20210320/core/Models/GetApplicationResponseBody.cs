// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// 操作列表。
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyApplicationActions> Actions { get; set; }
            public class GetApplicationResponseBodyApplicationActions : TeaModel {
                /// <summary>
                /// 操作名称。
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// 操作参数。
                /// </summary>
                [NameInMap("ActionParams")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyApplicationActionsActionParams> ActionParams { get; set; }
                public class GetApplicationResponseBodyApplicationActionsActionParams : TeaModel {
                    /// <summary>
                    /// 动作参数描述。
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// 动作参数KEY。
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// 动作参数属性。
                    /// </summary>
                    [NameInMap("ValueAttribute")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute ValueAttribute { get; set; }
                    public class GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute : TeaModel {
                        /// <summary>
                        /// 值表述。
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// 值步长。
                        /// </summary>
                        [NameInMap("ValueIncrementStep")]
                        [Validation(Required=false)]
                        public string ValueIncrementStep { get; set; }

                        /// <summary>
                        /// 最大值。
                        /// </summary>
                        [NameInMap("ValueMaximum")]
                        [Validation(Required=false)]
                        public string ValueMaximum { get; set; }

                        /// <summary>
                        /// 最小值。
                        /// </summary>
                        [NameInMap("ValueMinimum")]
                        [Validation(Required=false)]
                        public string ValueMinimum { get; set; }

                        /// <summary>
                        /// 属性值类型。
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                        /// <summary>
                        /// 值单位。
                        /// </summary>
                        [NameInMap("ValueUnit")]
                        [Validation(Required=false)]
                        public string ValueUnit { get; set; }

                    }

                }

                /// <summary>
                /// 命令。
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// 组件名称。
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// 操作描述。
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 执行范围。
                /// </summary>
                [NameInMap("RunActionScope")]
                [Validation(Required=false)]
                public string RunActionScope { get; set; }

            }

            /// <summary>
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 应用操作状态。
            /// </summary>
            [NameInMap("ApplicationState")]
            [Validation(Required=false)]
            public string ApplicationState { get; set; }

            /// <summary>
            /// 应用版本。
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// 社区版本。
            /// </summary>
            [NameInMap("CommunityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
