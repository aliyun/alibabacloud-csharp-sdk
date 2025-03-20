// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppLogRiverRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2852396.html">ListEdgeContainerApps</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The log path of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/hello.log</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect the standard output of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stdout")]
        [Validation(Required=false)]
        public bool? Stdout { get; set; }

    }

}
