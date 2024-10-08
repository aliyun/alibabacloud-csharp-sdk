// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dcdn_log_er</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ClientRequestID,ClientRequestHost</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;ClientSSLProtocol&quot;: {&quot;equals&quot;: [&quot;TLSv1.3&quot;]}}]</para>
        /// </summary>
        [NameInMap("FilterRules")]
        [Validation(Required=false)]
        public string FilterRules { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7072132a-bd3c-46a6-9e81-aba3e0e3f861</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;Project\&quot;: \&quot;er-online-hjy-pro\&quot;, \&quot;Logstore\&quot;: \&quot;er-online-hjy-log\&quot;, \&quot;Region\&quot;: \&quot;cn-hangzhou\&quot;, \&quot;Endpoint\&quot;: \&quot;cn-hangzhou.log.aliyuncs.com\&quot;, \&quot;Aliuid\&quot;: \&quot;1077912128805410\&quot;}</para>
        /// </summary>
        [NameInMap("SinkConfig")]
        [Validation(Required=false)]
        public object SinkConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testoss11</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
