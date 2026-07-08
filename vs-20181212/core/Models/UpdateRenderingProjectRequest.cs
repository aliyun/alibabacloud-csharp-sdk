// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateRenderingProjectRequest : TeaModel {
        /// <summary>
        /// <para>Project description</para>
        /// 
        /// <b>Example:</b>
        /// <para>目录1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Default naming rules:</para>
        /// <ol>
        /// <item><description><para>Length 1-128</para>
        /// </description></item>
        /// <item><description><para>Lowercase letters, numbers, underscores (_), hyphens (-), and periods (.).</para>
        /// </description></item>
        /// <item><description><para>The first and last characters must be letters or digits. At least one of ProjectName, SessionAttribs, or Description must be specified.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>idata_content</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Session attributes</para>
        /// </summary>
        [NameInMap("SessionAttribs")]
        [Validation(Required=false)]
        public UpdateRenderingProjectRequestSessionAttribs SessionAttribs { get; set; }
        public class UpdateRenderingProjectRequestSessionAttribs : TeaModel {
            /// <summary>
            /// <para>The mode used to start cloud application services for the session. Valid values:</para>
            /// <ol>
            /// <item><description><para>Async: asynchronous</para>
            /// </description></item>
            /// <item><description><para>Sync: synchronization</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Async</para>
            /// </summary>
            [NameInMap("StartMode")]
            [Validation(Required=false)]
            public string StartMode { get; set; }

        }

    }

}
