// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateConversationalAutomationRequest : TeaModel {
        /// <summary>
        /// <para>The list of commands.</para>
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<UpdateConversationalAutomationRequestCommands> Commands { get; set; }
        public class UpdateConversationalAutomationRequestCommands : TeaModel {
            /// <summary>
            /// <para>The command description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Command 1</para>
            /// </summary>
            [NameInMap("CommandDescription")]
            [Validation(Required=false)]
            public string CommandDescription { get; set; }

            /// <summary>
            /// <para>The command name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

        }

        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2993****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the welcome message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWelcomeMessage")]
        [Validation(Required=false)]
        public bool? EnableWelcomeMessage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The business phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86130000***</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The list of conversation starters.</para>
        /// </summary>
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
