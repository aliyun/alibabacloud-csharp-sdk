// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppStatusRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> to obtain the application ID. Before calling this operation, you must first activate the edge container service by calling OpenEdgeContainer, and then confirm that an available application exists by calling ListEdgeContainerApps or create an application by calling CreateEdgeContainerApp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The publishing environment. Valid values: prod and staging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("PublishEnv")]
        [Validation(Required=false)]
        public string PublishEnv { get; set; }

    }

}
