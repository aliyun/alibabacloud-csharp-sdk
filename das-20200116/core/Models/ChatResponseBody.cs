// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>waiting_for_agent_thinking</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>I see you have several PolarDB instances, and I will query them for you shortly</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Delta")]
        [Validation(Required=false)]
        public string Delta { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>61820b594664275c4429****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76bee207-31ee-4707-8851-6b9d4da033aa</para>
        /// </summary>
        [NameInMap("ParentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ed7cb7b1-ddc8-45d7-9ff3-b315726cb5f7</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sub_agent_performance_diagnose_mysql</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>das_api</para>
        /// </summary>
        [NameInMap("TaskTrackerId")]
        [Validation(Required=false)]
        public string TaskTrackerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8e481be1-21d5-4a92-a2fb-fb54be0ab4f6</para>
        /// </summary>
        [NameInMap("ThreadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>call_edf9cdb69e0e4c9796a6a5a6</para>
        /// </summary>
        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>das_api</para>
        /// </summary>
        [NameInMap("ToolCallName")]
        [Validation(Required=false)]
        public string ToolCallName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEXT_MESSAGE_CONTENT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;CharCount&quot;:393,&quot;End&quot;:1777428785996,&quot;RequestId&quot;:&quot;BE59AED5-D831-5811-BBAD-590B917B2089&quot;,&quot;SessionId&quot;:&quot;123e4567-e89b-12d3-a456-xxxxxxxxxxxx&quot;,&quot;Start&quot;:1777428707927}</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
