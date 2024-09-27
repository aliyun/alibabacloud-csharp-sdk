// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class ListTerminalCommandsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TerminalCommandList")]
        [Validation(Required=false)]
        public List<ListTerminalCommandsResponseBodyTerminalCommandList> TerminalCommandList { get; set; }
        public class ListTerminalCommandsResponseBodyTerminalCommandList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ls</para>
            /// </summary>
            [NameInMap("CommandLine")]
            [Validation(Required=false)]
            public string CommandLine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-16T03:53:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/root</para>
            /// </summary>
            [NameInMap("ExecutePath")]
            [Validation(Required=false)]
            public string ExecutePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("LoginUser")]
            [Validation(Required=false)]
            public string LoginUser { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
