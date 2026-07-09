// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The record.</para>
        /// </summary>
        [NameInMap("record")]
        [Validation(Required=false)]
        public GetServiceRecordResponseBodyRecord Record { get; set; }
        public class GetServiceRecordResponseBodyRecord : TeaModel {
            /// <summary>
            /// <para>The entry content in JSON string format. The returned content varies depending on the recordType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;project&quot;:&quot;proj-xtrace-16c988dcfe21fcb73c5e6f234927d998-cn-hangzhou&quot;,&quot;storeName&quot;:&quot;app-biz-log&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;bindType&quot;:&quot;logstore&quot;,&quot;traceIdRelateField&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("recordContent")]
            [Validation(Required=false)]
            public string RecordContent { get; set; }

            /// <summary>
            /// <para>The type of the linked entry. Currently supported values:
            /// logCorrelation: indicates application log association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logCorrelation</para>
            /// </summary>
            [NameInMap("recordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ckj0xn6ma3@b96491402f8e1f15a8c79</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-1610600919225911-cn-beijing</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
