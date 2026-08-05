// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of playlists.</para>
        /// </summary>
        [NameInMap("ProgramList")]
        [Validation(Required=false)]
        public List<ListPlaylistResponseBodyProgramList> ProgramList { get; set; }
        public class ListPlaylistResponseBodyProgramList : TeaModel {
            /// <summary>
            /// <para>The ID of the production studio to which the playlist belongs. Use this ID as a request parameter to add, delete, modify, or query the layout of a virtual studio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>casdfasdfasfdasdflkasjdflaj****</para>
            /// </summary>
            [NameInMap("CasterId")]
            [Validation(Required=false)]
            public string CasterId { get; set; }

            /// <summary>
            /// <para>The streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The ID of the playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
            /// </summary>
            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            /// <summary>
            /// <para>The name of the playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>playlist1</para>
            /// </summary>
            [NameInMap("ProgramName")]
            [Validation(Required=false)]
            public string ProgramName { get; set; }

            /// <summary>
            /// <para>The number of times the playlist repeats after the first playback. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): The playlist does not repeat.</para>
            /// </description></item>
            /// <item><description><para><b>-1</b>: The playlist plays in a loop.</para>
            /// </description></item>
            /// <item><description><para>Other positive integers: The number of times the playlist repeats.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatNumber")]
            [Validation(Required=false)]
            public int? RepeatNumber { get; set; }

            /// <summary>
            /// <para>The status of the playlist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: stopped.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of playlists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
