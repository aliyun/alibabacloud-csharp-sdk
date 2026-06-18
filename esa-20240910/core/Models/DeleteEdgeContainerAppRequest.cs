// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteEdgeContainerAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID. 
        /// <notice>AppId is required. If this parameter is not specified, the API returns InvalidParameter.appid (400). You can obtain the value by calling ListEdgeContainerApps.
        /// The AppId value is in the format of the app- prefix followed by 18 or more digits (at least 20 characters in total). You can obtain the actual value from the AppId field in the ListEdgeContainerApps response.</notice>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1232321454***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
