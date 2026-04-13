// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class GetChatResponseBody : TeaModel {
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public ChatDetail Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chat-jkd******</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;solutionDetail&quot;:{&quot;formValues&quot;:{&quot;params&quot;:{&quot;InstanceId&quot;:&quot;dsw-g54******qg9&quot;},&quot;content&quot;:{&quot;EcsSpec&quot;:&quot;ecs.gn6i-c8g1.2xlarge&quot;}},&quot;success&quot;:true}}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-01T17:52:05+08:00</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>how to ******</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500******860</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public ChatDetail Question { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44553E9A-******-37ADC33FE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>se-dss******</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>how to ******</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2100******360</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
