// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigRuleEvaluationByResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource.</para>
        /// <para>For more information about how to obtain the resource ID, see <a href="https://help.aliyun.com/document_detail/169620.html">ListDiscoveredResources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp151g9tpto890zr****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
