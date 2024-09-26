// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C12E7A51-09A4-5796-94BE-08B6DA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the subtasks.</para>
        /// </summary>
        [NameInMap("SubscriptionMetaList")]
        [Validation(Required=false)]
        public List<DescribeSubscriptionMetaResponseBodySubscriptionMetaList> SubscriptionMetaList { get; set; }
        public class DescribeSubscriptionMetaResponseBodySubscriptionMetaList : TeaModel {
            /// <summary>
            /// <para>The consumer offset of the subtask. It is a UNIX timestamp that is generated when the client consumes the first data record. Unit: seconds.</para>
            /// <remarks>
            /// <para> You can use a search engine to obtain a UNIX timestamp converter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1610524452</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public long? Checkpoint { get; set; }

            /// <summary>
            /// <para>The objects of the subtask. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects of DTS tasks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;dtstestdata\&quot;:{\&quot;name\&quot;:\&quot;dtstestdata\&quot;,\&quot;all\&quot;:false,\&quot;Table\&quot;:{\&quot;order\&quot;:{\&quot;name\&quot;:\&quot;order\&quot;,\&quot;all\&quot;:true}}}}</para>
            /// </summary>
            [NameInMap("DBList")]
            [Validation(Required=false)]
            public string DBList { get; set; }

            /// <summary>
            /// <para>The endpoint and port number of the change tracking instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts-cn-hangzhou.aliyuncs.com:18001</para>
            /// </summary>
            [NameInMap("DProxyUrl")]
            [Validation(Required=false)]
            public string DProxyUrl { get; set; }

            /// <summary>
            /// <para>The consumer group ID of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>z38m91gg2******</para>
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// <para>The topic of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_hangzhou_rm_bp1n0x0x5tz******_dtstestdata_version2</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
