// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotChatRequest : TeaModel {
        /// <summary>
        /// The ID of the bot instance.
        /// </summary>
        [NameInMap("ChatBotInstanceId")]
        [Validation(Required=false)]
        public string ChatBotInstanceId { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The name of the intent in the dialog flow. When this parameter is specified, the bot conducts a Q\&A based on the intent.
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The ID of the knowledge title in the knowledge base.
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// The list of codes for answers from different perspectives.
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// The ID of the visitor, which is used to identify users in the current session.
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// The nickname of the visitor in the current session.
        /// </summary>
        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// The ID of the session, which is used to identify the session and store context information of the session.
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

        /// <summary>
        /// The user-defined parameter set in JSON format. You can specify user-defined parameters for conversation engines.
        /// </summary>
        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> VendorParam { get; set; }

    }

}
