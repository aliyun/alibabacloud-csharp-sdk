// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderStatusCheckJobResponseBody : TeaModel {
        [NameInMap("IdentityProviderStatusCheckJob")]
        [Validation(Required=false)]
        public GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJob IdentityProviderStatusCheckJob { get; set; }
        public class GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJob : TeaModel {
            /// <summary>
            /// <para>任务检查结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public string CheckResult { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763776265757</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>IdP身份提供方</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_ncehkms65fiefobrvwy2blrxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>IdP状态检查任务Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>async_000036tfu8cgngmakngrr2rk75qgf87pf3rxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderStatusCheckJobId")]
            [Validation(Required=false)]
            public string IdentityProviderStatusCheckJobId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ki6hd7ihir4ybawogqk6kqsfxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>状态检查子项任务结果信息</para>
            /// </summary>
            [NameInMap("JobCheckItems")]
            [Validation(Required=false)]
            public List<GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJobJobCheckItems> JobCheckItems { get; set; }
            public class GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJobJobCheckItems : TeaModel {
                /// <summary>
                /// <para>错误原因</para>
                /// </summary>
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJobJobCheckItemsErrorReason ErrorReason { get; set; }
                public class GetIdentityProviderStatusCheckJobResponseBodyIdentityProviderStatusCheckJobJobCheckItemsErrorReason : TeaModel {
                    /// <summary>
                    /// <para>错误码</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NetworkAccessPointWarning.SingleNetworkAccessPath</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>错误级别</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("ErrorLevel")]
                    [Validation(Required=false)]
                    public string ErrorLevel { get; set; }

                    /// <summary>
                    /// <para>错误信息</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is only one path in the current network access endpoint.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>主要检查项</para>
                /// 
                /// <b>Example:</b>
                /// <para>network_check</para>
                /// </summary>
                [NameInMap("MajorCheckItem")]
                [Validation(Required=false)]
                public string MajorCheckItem { get; set; }

                /// <summary>
                /// <para>次要检查项</para>
                /// 
                /// <b>Example:</b>
                /// <para>network_access_status</para>
                /// </summary>
                [NameInMap("MinorCheckItem")]
                [Validation(Required=false)]
                public string MinorCheckItem { get; set; }

                /// <summary>
                /// <para>结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>开始时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763776265757</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>任务检查状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
