// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInTransferRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCallInTransferRecordResponseBodyData Data { get; set; }
        public class QueryCallInTransferRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The call transfer records.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<QueryCallInTransferRecordResponseBodyDataValues> Values { get; set; }
            public class QueryCallInTransferRecordResponseBodyDataValues : TeaModel {
                /// <summary>
                /// <para>The called number of the inbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("CallInCalled")]
                [Validation(Required=false)]
                public string CallInCalled { get; set; }

                /// <summary>
                /// <para>The calling number of the inbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("CallInCaller")]
                [Validation(Required=false)]
                public string CallInCaller { get; set; }

                /// <summary>
                /// <para>The time when the call was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-03 10:21:21</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The recording URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://alicom-fc-media.cn-hangzhou.oss.aliyun-inc.com/dayuBizVoiceMrg/4238c230-9e74-41be-90b8-2fbe7684****.wav?Expires=1627538265&OSSAccessKeyId=bypFNbGJVk73****&Signature=****mUqkPqIQ%3D">http://alicom-fc-media.cn-hangzhou.oss.aliyun-inc.com/dayuBizVoiceMrg/4238c230-9e74-41be-90b8-2fbe7684****.wav?Expires=1627538265&amp;OSSAccessKeyId=bypFNbGJVk73****&amp;Signature=****mUqkPqIQ%3D</a></para>
                /// </summary>
                [NameInMap("RecordUrl")]
                [Validation(Required=false)]
                public string RecordUrl { get; set; }

                /// <summary>
                /// <para>The phone number to which the call was transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>151****0000</para>
                /// </summary>
                [NameInMap("TransferCalled")]
                [Validation(Required=false)]
                public string TransferCalled { get; set; }

                /// <summary>
                /// <para>The calling number that transferred the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>151****0000</para>
                /// </summary>
                [NameInMap("TransferCaller")]
                [Validation(Required=false)]
                public string TransferCaller { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
