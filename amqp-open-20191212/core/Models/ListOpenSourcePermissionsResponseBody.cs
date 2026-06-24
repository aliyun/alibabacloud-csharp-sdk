// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListOpenSourcePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOpenSourcePermissionsResponseBodyData> Data { get; set; }
        public class ListOpenSourcePermissionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("AliyunUserId")]
            [Validation(Required=false)]
            public long? AliyunUserId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-v0h1kb9nu***</para>
            /// </summary>
            [NameInMap("CInstanceId")]
            [Validation(Required=false)]
            public string CInstanceId { get; set; }

            /// <summary>
            /// <para>The regular expression for configure permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^$</para>
            /// </summary>
            [NameInMap("Configure")]
            [Validation(Required=false)]
            public string Configure { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shhtzn</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The regular expression for read permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^$</para>
            /// </summary>
            [NameInMap("Read")]
            [Validation(Required=false)]
            public string Read { get; set; }

            /// <summary>
            /// <para>The vhost name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("Vhost")]
            [Validation(Required=false)]
            public string Vhost { get; set; }

            /// <summary>
            /// <para>The regular expression for write permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order_exchange</para>
            /// </summary>
            [NameInMap("Write")]
            [Validation(Required=false)]
            public string Write { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEBA5E0C-50D0-4FA6-A794-4901E5465***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
