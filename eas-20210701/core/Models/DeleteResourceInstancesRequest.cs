// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteResourceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all the instances that fail to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllFailed")]
        [Validation(Required=false)]
        public bool? AllFailed { get; set; }

        /// <summary>
        /// <para>The instances. Separate multiple instances with commas (,), such as <c>instanceId1,instanceId2</c>. For more information about how to query the instances, see <a href="https://help.aliyun.com/document_detail/412129.html">ListResourceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-i-xxxxxxx,eas-i-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

    }

}
