// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateResponseBody : TeaModel {
        /// <summary>
        /// 联想的列表
        /// </summary>
        [NameInMap("Associate")]
        [Validation(Required=false)]
        public List<AssociateResponseBodyAssociate> Associate { get; set; }
        public class AssociateResponseBodyAssociate : TeaModel {
            /// <summary>
            /// 附带信息
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// 关联问题的标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 本条会话应答消息的ID
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次会话的ID
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
