// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppLogRiverRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="https://help.aliyun.com/document_detail/2852396.html">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: The AppId is in the format of the app- prefix followed by a numeric suffix, with a total length of 20 to 64 characters (example: app-8806886***83794688). Call ListEdgeContainerApps to obtain an existing AppId, or call CreateEdgeContainerApp to create an application first.</notice>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The log file of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/hello.log</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable standard output collection for the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stdout")]
        [Validation(Required=false)]
        public bool? Stdout { get; set; }

    }

}
