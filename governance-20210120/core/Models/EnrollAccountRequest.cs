/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class EnrollAccountRequest : TeaModel {
        /// <summary>
        /// 账号名称前缀
        /// </summary>
        [NameInMap("AccountNamePrefix")]
        [Validation(Required=false)]
        public string AccountNamePrefix { get; set; }

        /// <summary>
        /// 注册账号ID
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// 基线项配置数组
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<EnrollAccountRequestBaselineItems> BaselineItems { get; set; }
        public class EnrollAccountRequestBaselineItems : TeaModel {
            /// <summary>
            /// 基线项配置
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// 基线项名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否跳过基线项
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// 基线项版本
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// 账号显示名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 父资源夹ID
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// 结算账号ID
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
