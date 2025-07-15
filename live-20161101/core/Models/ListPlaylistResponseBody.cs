// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The episode lists.</para>
        /// </summary>
        [NameInMap("ProgramList")]
        [Validation(Required=false)]
        public List<ListPlaylistResponseBodyProgramList> ProgramList { get; set; }
        public class ListPlaylistResponseBodyProgramList : TeaModel {
            /// <summary>
            /// <para>The ID of the production studio to which the episode list belongs. You can use the ID as a request parameter in the API operation that is used to add a layout to the virtual studio, delete a layout in the virtual studio, modify a layout of the virtual studio, or query layouts of the virtual studio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>casdfasdfasfdasdflkasjdflaj****</para>
            /// </summary>
            [NameInMap("CasterId")]
            [Validation(Required=false)]
            public string CasterId { get; set; }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The ID of the episode list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
            /// </summary>
            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            /// <summary>
            /// <para>The name of the episode list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>playlist1</para>
            /// </summary>
            [NameInMap("ProgramName")]
            [Validation(Required=false)]
            public string ProgramName { get; set; }

            /// <summary>
            /// <para>The number of playbacks after the first playback is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (default): specifies that the episode list is played only once.</description></item>
            /// <item><description><b>-1</b>: specifies that the episode list is played in loop mode.</description></item>
            /// <item><description>Positive integer: specifies the number of times the episode list repeats after the first playback is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatNumber")]
            [Validation(Required=false)]
            public int? RepeatNumber { get; set; }

            /// <summary>
            /// <para>The status of the episode list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: stopped</description></item>
            /// <item><description><b>1</b>: running</description></item>
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
        /// <para>The total number of episode lists returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
