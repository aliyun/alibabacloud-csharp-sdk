// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVMDeployOrderResponseBody : TeaModel {
        [NameInMap("deployOrder")]
        [Validation(Required=false)]
        public GetVMDeployOrderResponseBodyDeployOrder DeployOrder { get; set; }
        public class GetVMDeployOrderResponseBodyDeployOrder : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<GetVMDeployOrderResponseBodyDeployOrderActions> Actions { get; set; }
            public class GetVMDeployOrderResponseBodyDeployOrderActions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("disable")]
                [Validation(Required=false)]
                public bool? Disable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public object Params { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>StopVMDeployOrder</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111111111</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ssaassa</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("currentBatch")]
            [Validation(Required=false)]
            public int? CurrentBatch { get; set; }

            [NameInMap("deployMachineInfo")]
            [Validation(Required=false)]
            public GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfo DeployMachineInfo { get; set; }
            public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("batchNum")]
                [Validation(Required=false)]
                public int? BatchNum { get; set; }

                [NameInMap("deployMachines")]
                [Validation(Required=false)]
                public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines> DeployMachines { get; set; }
                public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachines : TeaModel {
                    [NameInMap("actions")]
                    [Validation(Required=false)]
                    public List<GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions> Actions { get; set; }
                    public class GetVMDeployOrderResponseBodyDeployOrderDeployMachineInfoDeployMachinesActions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("disable")]
                        [Validation(Required=false)]
                        public bool? Disable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public object Params { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>RetryVMDeployMachine</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("batchNum")]
                    [Validation(Required=false)]
                    public int? BatchNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ok</para>
                    /// </summary>
                    [NameInMap("clientStatus")]
                    [Validation(Required=false)]
                    public string ClientStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1111111111</para>
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>127.0.0.1</para>
                    /// </summary>
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sasssasa</para>
                    /// </summary>
                    [NameInMap("machineSn")]
                    [Validation(Required=false)]
                    public string MachineSn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11111111</para>
                    /// </summary>
                    [NameInMap("updateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("hostGroupId")]
                [Validation(Required=false)]
                public long? HostGroupId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("deployOrderId")]
            [Validation(Required=false)]
            public string DeployOrderId { get; set; }

            [NameInMap("exceptionCode")]
            [Validation(Required=false)]
            public string ExceptionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("totalBatch")]
            [Validation(Required=false)]
            public int? TotalBatch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true 接口调用成功，false 接口调用失败</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
