// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetEnrolledAccountResponseBody : TeaModel {
        /// <summary>
        /// 账号ID
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 账号显示名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetEnrolledAccountResponseBodyErrorInfo : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Recommend")]
            [Validation(Required=false)]
            public string Recommend { get; set; }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
        };

        /// <summary>
        /// 父资源夹ID
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// 是否初始化完成
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// 注册账号时的输入参数
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyInputs Inputs { get; set; }
        public class GetEnrolledAccountResponseBodyInputs : TeaModel {
            [NameInMap("AccountNamePrefix")]
            [Validation(Required=false)]
            public string AccountNamePrefix { get; set; }
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }
            [NameInMap("BaselineItems")]
            [Validation(Required=false)]
            public List<GetEnrolledAccountResponseBodyInputsBaselineItems> BaselineItems { get; set; }
            public class GetEnrolledAccountResponseBodyInputsBaselineItems : TeaModel {
                public string Config { get; set; }
                public string Name { get; set; }
                public bool? Skip { get; set; }
                public string Version { get; set; }
            }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }
        };

        /// <summary>
        /// 所属的Master账号ID
        /// </summary>
        [NameInMap("MasterAccountUid")]
        [Validation(Required=false)]
        public long? MasterAccountUid { get; set; }

        /// <summary>
        /// 结算账号ID
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// 基线实施进度
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyProgress> Progress { get; set; }
        public class GetEnrolledAccountResponseBodyProgress : TeaModel {
            /// <summary>
            /// 基线项名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 基线项实施状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 账号注册状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
