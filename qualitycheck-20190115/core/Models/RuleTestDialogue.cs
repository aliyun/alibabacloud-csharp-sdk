// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleTestDialogue : TeaModel {
        /// <summary>
        /// <para>Content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<RuleTestDialogueContent> Content { get; set; }
        public class RuleTestDialogueContent : TeaModel {
            /// <summary>
            /// <para>Start Time in long</para>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public long? Begin { get; set; }

            /// <summary>
            /// <para>Start Time in long</para>
            /// 
            /// <b>Example:</b>
            /// <para>350</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>Emotion energy value</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EmotionValue")]
            [Validation(Required=false)]
            public int? EmotionValue { get; set; }

            /// <summary>
            /// <para>End time in long</para>
            /// 
            /// <b>Example:</b>
            /// <para>1360</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Hour, minute, second</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("HourMinSec")]
            [Validation(Required=false)]
            public string HourMinSec { get; set; }

            /// <summary>
            /// <para>Identity</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户</para>
            /// </summary>
            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            /// <summary>
            /// <para>Role</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Silence duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SilenceDuration")]
            [Validation(Required=false)]
            public long? SilenceDuration { get; set; }

            /// <summary>
            /// <para>Speech rate</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SpeechRate")]
            [Validation(Required=false)]
            public long? SpeechRate { get; set; }

            /// <summary>
            /// <para>Dialogue</para>
            /// 
            /// <b>Example:</b>
            /// <para>方便</para>
            /// </summary>
            [NameInMap("Words")]
            [Validation(Required=false)]
            public string Words { get; set; }

        }

        /// <summary>
        /// <para>Conversation ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Conversation Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>group</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
