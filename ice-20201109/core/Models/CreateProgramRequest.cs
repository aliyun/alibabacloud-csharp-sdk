// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateProgramRequest : TeaModel {
        /// <summary>
        /// <para>The information about ad breaks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;MessageType&quot;:&quot;SPLICE_INSERT&quot;,&quot;OffsetMillis&quot;:1000,&quot;SourceLocationName&quot;:&quot;MySourceLocation&quot;,&quot;SourceName&quot;:&quot;MyAdSource&quot;,&quot;SpliceInsertSettings&quot;:{&quot;AvailNumber&quot;:0,&quot;AvailExpected&quot;:0,&quot;SpliceEventID&quot;:1,&quot;UniqueProgramID&quot;:0}}]</para>
        /// </summary>
        [NameInMap("AdBreaks")]
        [Validation(Required=false)]
        public string AdBreaks { get; set; }

        /// <summary>
        /// <para>The name of the channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>Extracts a clip from the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{StartOffsetMillis: 213123, EndOffsetMillis: 213134}</para>
        /// </summary>
        [NameInMap("ClipRange")]
        [Validation(Required=false)]
        public string ClipRange { get; set; }

        /// <summary>
        /// <para>The name of the program.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program1</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The source location.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLcation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySource</para>
        /// </summary>
        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The source type of the program.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vodSource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The program transition method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;RELATIVE&quot;, &quot;RelativePosition&quot;: &quot;AFTER_PROGRAM&quot;, &quot;RelativeProgram&quot;: &quot;program2&quot;}</para>
        /// </summary>
        [NameInMap("Transition")]
        [Validation(Required=false)]
        public string Transition { get; set; }

    }

}
