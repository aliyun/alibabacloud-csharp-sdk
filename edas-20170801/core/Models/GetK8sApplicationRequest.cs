// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-4f98-a286-781659d9</b></b></para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The source from which data is queried.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, a common query is performed.</description></item>
        /// <item><description>If you set the value to deploy, you query application information from the deployment page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deploy</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}
