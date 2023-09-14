// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotAssociateRequest : TeaModel {
        /// <summary>
        /// The ID of a bot instance.
        /// </summary>
        [NameInMap("ChatBotInstanceId")]
        [Validation(Required=false)]
        public string ChatBotInstanceId { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by ISV.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The list of codes for answers from different perspectives.
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// The number of recommended questions. The value ranges from 1 to 10.
        /// </summary>
        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public int? RecommendNum { get; set; }

        /// <summary>
        /// The ID of the session, which is used to identify the session and store context information in the session.
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// The input of the visitor.
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
