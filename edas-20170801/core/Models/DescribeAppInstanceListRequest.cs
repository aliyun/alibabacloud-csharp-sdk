// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeAppInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the ID of the application. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93fdd228-*****-ed2ae98de18d</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the information about the node in which the pod resides.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: returns the information about the node in which the pod resides</description></item>
        /// <item><description><c>false</c>: does not return the information about the node in which the pod resides</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithNodeInfo")]
        [Validation(Required=false)]
        public bool? WithNodeInfo { get; set; }

    }

}
