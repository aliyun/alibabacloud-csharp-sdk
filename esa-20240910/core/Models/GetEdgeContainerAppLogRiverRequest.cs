// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppLogRiverRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.
        /// <notice>AppId is a required parameter. If this parameter is not specified, the API returns InvalidParameter.appid (400). You can call the ListEdgeContainerApps operation to obtain a valid AppId.</notice>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-880688675****88</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
