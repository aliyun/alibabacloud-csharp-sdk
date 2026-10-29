// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of projects.</para>
        /// </summary>
        [NameInMap("Projects")]
        [Validation(Required=false)]
        public List<ListRenderingProjectsResponseBodyProjects> Projects { get; set; }
        public class ListRenderingProjectsResponseBodyProjects : TeaModel {
            /// <summary>
            /// <para>The time when the project was created. The time follows the ISO 8601 standard and includes a time zone offset in the YYYY-MM-DDTHH:mm:ss+HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-09T18:44:49+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The session attributes of the project.</para>
            /// </summary>
            [NameInMap("SessionAttribs")]
            [Validation(Required=false)]
            public ListRenderingProjectsResponseBodyProjectsSessionAttribs SessionAttribs { get; set; }
            public class ListRenderingProjectsResponseBodyProjectsSessionAttribs : TeaModel {
                /// <summary>
                /// <para>The startup mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sync</para>
                /// </summary>
                [NameInMap("StartMode")]
                [Validation(Required=false)]
                public string StartMode { get; set; }

            }

            /// <summary>
            /// <para>The time when the project was updated. The time follows the ISO 8601 standard and includes a time zone offset in the YYYY-MM-DDTHH:mm:ss+HH:mm format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-09T18:44:49+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matched projects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
