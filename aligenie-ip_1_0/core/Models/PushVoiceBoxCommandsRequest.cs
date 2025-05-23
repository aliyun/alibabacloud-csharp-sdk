// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushVoiceBoxCommandsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Commands")]
        [Validation(Required=false)]
        public List<PushVoiceBoxCommandsRequestCommands> Commands { get; set; }
        public class PushVoiceBoxCommandsRequestCommands : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CommandDomain")]
            [Validation(Required=false)]
            public string CommandDomain { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CommandName")]
            [Validation(Required=false)]
            public string CommandName { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}
