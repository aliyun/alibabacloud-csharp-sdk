// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateConversationalAutomationRequest : TeaModel {
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<UpdateConversationalAutomationRequestCommands> Commands { get; set; }
        public class UpdateConversationalAutomationRequestCommands : TeaModel {
            [NameInMap("CommandDescription")]
            [Validation(Required=false)]
            public string CommandDescription { get; set; }

            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("EnableWelcomeMessage")]
        [Validation(Required=false)]
        public bool? EnableWelcomeMessage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("Prompts")]
        [Validation(Required=false)]
        public List<string> Prompts { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
