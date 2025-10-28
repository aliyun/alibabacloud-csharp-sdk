// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertDeployGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-4413-***********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the instance group. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The version of the initial deployment package associated with the instance group. You can call the ListHistoryDeployVersion operation to query the version. For more information, see <a href="https://help.aliyun.com/document_detail/149392.html">ListHistoryDeployVersion</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>441beb18-da42-44dc-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("InitPackageVersionId")]
        [Validation(Required=false)]
        public string InitPackageVersionId { get; set; }

    }

}
