// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppStatusRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The release environment. Valid values: prod and staging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("PublishEnv")]
        [Validation(Required=false)]
        public string PublishEnv { get; set; }

    }

}
