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
            /// <para>操作列表。</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyApplicationActions> Actions { get; set; }
            public class GetApplicationResponseBodyApplicationActions : TeaModel {
                /// <summary>
                /// <para>操作名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>START</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>操作参数。</para>
                /// </summary>
                [NameInMap("ActionParams")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyApplicationActionsActionParams> ActionParams { get; set; }
                public class GetApplicationResponseBodyApplicationActionsActionParams : TeaModel {
                    /// <summary>
                    /// <para>动作参数描述。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>start</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>动作参数KEY。</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>动作参数属性。</para>
                    /// </summary>
                    [NameInMap("ValueAttribute")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute ValueAttribute { get; set; }
                    public class GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute : TeaModel {
                        /// <summary>
                        /// <para>值表述。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>描述</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>值步长。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("ValueIncrementStep")]
                        [Validation(Required=false)]
                        public string ValueIncrementStep { get; set; }

                        /// <summary>
                        /// <para>最大值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("ValueMaximum")]
                        [Validation(Required=false)]
                        public string ValueMaximum { get; set; }

                        /// <summary>
                        /// <para>最小值。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ValueMinimum")]
                        [Validation(Required=false)]
                        public string ValueMinimum { get; set; }

                        /// <summary>
                        /// <para>属性值类型。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                        /// <summary>
                        /// <para>值单位。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>number</para>
                        /// </summary>
                        [NameInMap("ValueUnit")]
                        [Validation(Required=false)]
                        public string ValueUnit { get; set; }

                    }

                }

                /// <summary>
                /// <para>命令。</para>
                /// 
                /// <b>Example:</b>
                /// <para>START</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>组件名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataNode</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>操作描述。</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>执行范围。</para>
                /// 
                /// <b>Example:</b>
                /// <para>CLUSTER</para>
                /// </summary>
                [NameInMap("RunActionScope")]
                [Validation(Required=false)]
                public string RunActionScope { get; set; }

            }

            /// <summary>
            /// <para>应用名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>应用操作状态。</para>
            /// </summary>
            [NameInMap("ApplicationState")]
            [Validation(Required=false)]
            public string ApplicationState { get; set; }

            /// <summary>
            /// <para>应用版本。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.5</para>
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// <para>社区版本。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.5</para>
            /// </summary>
            [NameInMap("CommunityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
