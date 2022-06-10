// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeDSEntityResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 实体ID
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// 实体名称，仅支持中文、大小写字母、数字、下划线
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类型：详见:,EntityTypeEnum[synonyms(同义词),regex(正则)]
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public string ModifyUserId { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 系统实体code，如@sys.date
        /// </summary>
        [NameInMap("SysEntityCode")]
        [Validation(Required=false)]
        public string SysEntityCode { get; set; }

    }

}
