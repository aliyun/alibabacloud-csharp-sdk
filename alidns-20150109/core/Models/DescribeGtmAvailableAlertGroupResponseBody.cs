// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAvailableAlertGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The available alert contact groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;研发组\&quot;,\&quot;GTM测试组\&quot;]</para>
        /// </summary>
        [NameInMap("AvailableAlertGroup")]
        [Validation(Required=false)]
        public string AvailableAlertGroup { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29D0F8F8-5499-4F6C-9FDC-1EE13BF55925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
