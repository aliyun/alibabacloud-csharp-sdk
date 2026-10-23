// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetClusterDataInformationRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type, access endpoint, and index to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataSourceType&quot;:&quot;elasticsearch&quot;,&quot;endpoint&quot;:&quot;<a href="http://es-cn-npk1shyiq000d****.public.elasticsearch.aliyuncs.com:9200%22,%22username%22:%22elastic%22,%22password%22:%22xxxxxx%22,%22index%22:%22default%22,%22type%22:%22default%22%7D">http://es-cn-npk1shyiq000d****.public.elasticsearch.aliyuncs.com:9200&quot;,&quot;username&quot;:&quot;elastic&quot;,&quot;password&quot;:&quot;xxxxxx&quot;,&quot;index&quot;:&quot;default&quot;,&quot;type&quot;:&quot;default&quot;}</a></para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
