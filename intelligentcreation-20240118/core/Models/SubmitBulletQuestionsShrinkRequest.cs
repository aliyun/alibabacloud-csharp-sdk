// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240118.Models
{
    public class SubmitBulletQuestionsShrinkRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// questions
        /// </summary>
        [NameInMap("questions")]
        [Validation(Required=false)]
        public string QuestionsShrink { get; set; }

        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("subAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

    }

}
