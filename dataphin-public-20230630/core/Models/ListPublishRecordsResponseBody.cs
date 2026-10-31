// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPublishRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListPublishRecordsResponseBodyListResult ListResult { get; set; }
        public class ListPublishRecordsResponseBodyListResult : TeaModel {
            /// <summary>
            /// <para>The publish record list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListPublishRecordsResponseBodyListResultData> Data { get; set; }
            public class ListPublishRecordsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <para>The change type. Valid values: 0: create. 1: update. 2: delete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                /// <summary>
                /// <para>The publish error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The publish completion time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:10:10</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The creation time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The ID of the publish record. This is not the object ID and is globally unique in the publish list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_123456</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("ObjectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Object A</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The object version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1241844456</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The publish name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_lc__20241118171502</para>
                /// </summary>
                [NameInMap("PublishName")]
                [Validation(Required=false)]
                public string PublishName { get; set; }

                /// <summary>
                /// <para>The publish status. Valid values: 0: failed. 1: successful. 2: publishing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public int? PublishStatus { get; set; }

                /// <summary>
                /// <para>The ID of the publisher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>307999999</para>
                /// </summary>
                [NameInMap("Publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

                /// <summary>
                /// <para>The name of the publisher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("PublisherName")]
                [Validation(Required=false)]
                public string PublisherName { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
