// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ExportConversationDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582266750353</para>
        /// </summary>
        [NameInMap("BeginTimeLeftRange")]
        [Validation(Required=false)]
        public long? BeginTimeLeftRange { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640793599000</para>
        /// </summary>
        [NameInMap("BeginTimeRightRange")]
        [Validation(Required=false)]
        public long? BeginTimeRightRange { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13581588**</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("DebugConversation")]
        [Validation(Required=false)]
        public int? DebugConversation { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c01a99f-1b72-4f75-a8bd-3875766bd19d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>An array of optional parameters.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// <para>The result of the conversation.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public int? Result { get; set; }

        /// <summary>
        /// <para>The minimum number of conversation turns.</para>
        /// </summary>
        [NameInMap("RoundsLeftRange")]
        [Validation(Required=false)]
        public int? RoundsLeftRange { get; set; }

        /// <summary>
        /// <para>The maximum number of conversation turns.</para>
        /// </summary>
        [NameInMap("RoundsRightRange")]
        [Validation(Required=false)]
        public int? RoundsRightRange { get; set; }

    }

}
