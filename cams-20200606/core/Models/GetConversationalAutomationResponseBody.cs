// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetConversationalAutomationResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConversationalAutomationResponseBodyData Data { get; set; }
        public class GetConversationalAutomationResponseBodyData : TeaModel {
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<GetConversationalAutomationResponseBodyDataCommands> Commands { get; set; }
            public class GetConversationalAutomationResponseBodyDataCommands : TeaModel {
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

            }

            [NameInMap("EnableWelcomeMessage")]
            [Validation(Required=false)]
            public bool? EnableWelcomeMessage { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("Prompts")]
            [Validation(Required=false)]
            public List<string> Prompts { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
