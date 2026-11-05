// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to be deleted. <b>This parameter is required</b>, and the application must belong to the current account. You must dissociate image references from the target application or version before deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-bp1example****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the application version to be deleted. If specified, only the adapters corresponding to this application version are deleted. If omitted, the entire application and its adapters are deleted. If the application has no other adapters after the version is deleted, the application record is also deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apv-bp1example****</para>
        /// </summary>
        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

    }

}
