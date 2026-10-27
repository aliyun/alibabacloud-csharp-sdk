// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendConsoleMessageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the console message to be sent. You can obtain the ID from the return value of the message creation operation or the query result of DescribeConsoleMessages. Each call supports only one message ID, and the message must belong to the current Alibaba Cloud account. Only messages in the Published state can be sent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg-123456</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
