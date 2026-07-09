// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListEventMetaCacheAllKeysDataResult : TeaModel {
        /// <summary>
        /// <para>annotation类型的Key列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;message&quot;,&quot;current_value&quot;]</para>
        /// </summary>
        [NameInMap("annotation")]
        [Validation(Required=false)]
        public List<string> Annotation { get; set; }

        /// <summary>
        /// <para>label类型的Key列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;_cms_rule_id&quot;,&quot;_cms_rule_name&quot;]</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public List<string> Label { get; set; }

        /// <summary>
        /// <para>resource.tag类型的Key列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;arn&quot;,&quot;callType&quot;]</para>
        /// </summary>
        [NameInMap("resourceTag")]
        [Validation(Required=false)]
        public List<string> ResourceTag { get; set; }

    }

}
