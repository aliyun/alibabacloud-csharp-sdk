// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public int? Clipboard { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-xxxxxxx</para>
        /// </summary>
        [NameInMap("CloudEnvId")]
        [Validation(Required=false)]
        public string CloudEnvId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-06vcpamarryyq****</para>
        /// </summary>
        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public string ContentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FileTransfer")]
        [Validation(Required=false)]
        public int? FileTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("KeepAliveDuration")]
        [Validation(Required=false)]
        public int? KeepAliveDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>notepad++xxxxx</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("SessionResolutionHeight")]
        [Validation(Required=false)]
        public int? SessionResolutionHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("SessionResolutionWidth")]
        [Validation(Required=false)]
        public int? SessionResolutionWidth { get; set; }

        [NameInMap("SessionSpec")]
        [Validation(Required=false)]
        public string SessionSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mix</para>
        /// </summary>
        [NameInMap("StreamingMode")]
        [Validation(Required=false)]
        public string StreamingMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TerminalResolutionAdaptation")]
        [Validation(Required=false)]
        public bool? TerminalResolutionAdaptation { get; set; }

    }

}
