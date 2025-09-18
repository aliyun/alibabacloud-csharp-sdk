// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The list of actions supported by the application.</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyApplicationActions> Actions { get; set; }
            public class GetApplicationResponseBodyApplicationActions : TeaModel {
                /// <summary>
                /// <para>The action name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>decommission</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>The list of action parameters.</para>
                /// </summary>
                [NameInMap("ActionParams")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyApplicationActionsActionParams> ActionParams { get; set; }
                public class GetApplicationResponseBodyApplicationActionsActionParams : TeaModel {
                    /// <summary>
                    /// <para>Description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>start</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>timeout</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The parameter value attribute.</para>
                    /// </summary>
                    [NameInMap("ValueAttribute")]
                    [Validation(Required=false)]
                    public GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute ValueAttribute { get; set; }
                    public class GetApplicationResponseBodyApplicationActionsActionParamsValueAttribute : TeaModel {
                        /// <summary>
                        /// <para>Value description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>描述</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The size of the value increment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ValueIncrementStep")]
                        [Validation(Required=false)]
                        public string ValueIncrementStep { get; set; }

                        /// <summary>
                        /// <para>The maximum range of values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ValueMaximum")]
                        [Validation(Required=false)]
                        public string ValueMaximum { get; set; }

                        /// <summary>
                        /// <para>The minimum range of values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ValueMinimum")]
                        [Validation(Required=false)]
                        public string ValueMinimum { get; set; }

                        /// <summary>
                        /// <para>The value type of the column.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>int</para>
                        /// </summary>
                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                        /// <summary>
                        /// <para>The unit of the value.</para>
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
                /// <para>The action command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>decommission</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataNode</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The description of the action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The execution scope. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>APPLICATION: the application scope.</description></item>
                /// <item><description>COMPONENT: the component scope.</description></item>
                /// <item><description>COMPONENT_INSTANCE: the component instance scope.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPONENT_INSTANCE</para>
                /// </summary>
                [NameInMap("RunActionScope")]
                [Validation(Required=false)]
                public string RunActionScope { get; set; }

            }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The status of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ApplicationState")]
            [Validation(Required=false)]
            public string ApplicationState { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.1</para>
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// <para>The community version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.1</para>
            /// </summary>
            [NameInMap("CommunityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
