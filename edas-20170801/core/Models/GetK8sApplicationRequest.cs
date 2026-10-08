// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-4f98-a286-781659d9</b></b></para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The source of the query.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is empty, a regular query is performed.</para>
        /// </description></item>
        /// <item><description><para>deploy: The query is initiated from the deployment page.</para>
        /// </description></item>
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
