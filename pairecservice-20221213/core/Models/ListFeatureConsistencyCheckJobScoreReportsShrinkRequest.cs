// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobScoreReportsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of request IDs to exclude from the feature comparison.</para>
        /// </summary>
        [NameInMap("ExcludeRequestIds")]
        [Validation(Required=false)]
        public string ExcludeRequestIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the instance. To obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
