// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LifecycleRule : TeaModel {
        /// <summary>
        /// 未完成分片上传的过期属性
        /// </summary>
        [NameInMap("AbortMultipartUpload")]
        [Validation(Required=false)]
        public LifecycleRuleLifecycleAbortMultipartUpload LifecycleAbortMultipartUpload { get; set; }
        public class LifecycleRuleLifecycleAbortMultipartUpload : TeaModel {
            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }
            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }
        };

        /// <summary>
        /// 过期属性
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public LifecycleRuleLifecycleExpiration LifecycleExpiration { get; set; }
        public class LifecycleRuleLifecycleExpiration : TeaModel {
            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }
            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }
            [NameInMap("ExpiredObjectDeleteMarker")]
            [Validation(Required=false)]
            public bool? ExpiredObjectDeleteMarker { get; set; }
        };

        /// <summary>
        /// 规则标识
        /// </summary>
        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        /// <summary>
        /// 非当前版本生命周期规则的过期属性
        /// </summary>
        [NameInMap("NoncurrentVersionExpiration")]
        [Validation(Required=false)]
        public LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration { get; set; }
        public class LifecycleRuleNoncurrentVersionExpiration : TeaModel {
            [NameInMap("NoncurrentDays")]
            [Validation(Required=false)]
            public int? NoncurrentDays { get; set; }
        };

        /// <summary>
        /// 非当前版本生命周期规则的转储属性
        /// </summary>
        [NameInMap("NoncurrentVersionTransition")]
        [Validation(Required=false)]
        public List<LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransition { get; set; }
        public class LifecycleRuleNoncurrentVersionTransition : TeaModel {
            /// <summary>
            /// 天数
            /// </summary>
            [NameInMap("NoncurrentDays")]
            [Validation(Required=false)]
            public int? NoncurrentDays { get; set; }

            /// <summary>
            /// 存储类型
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

        }

        /// <summary>
        /// 指定规则所适用的前缀
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// 规则的状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<LifecycleRuleTag> Tag { get; set; }
        public class LifecycleRuleTag : TeaModel {
            /// <summary>
            /// 标签 key
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签 value
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 存储类型转换
        /// </summary>
        [NameInMap("Transition")]
        [Validation(Required=false)]
        public List<LifecycleRuleLifecycleTransition> LifecycleTransition { get; set; }
        public class LifecycleRuleLifecycleTransition : TeaModel {
            /// <summary>
            /// 日期
            /// </summary>
            [NameInMap("CreatedBeforeDate")]
            [Validation(Required=false)]
            public string CreatedBeforeDate { get; set; }

            /// <summary>
            /// 天数
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

        }

    }

}
