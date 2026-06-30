// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListDataSetResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. <b>200</b> indicates success. Other values indicate failure. Callers can use this field to determine the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSetResponseBodyData Data { get; set; }
        public class ListDataSetResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListDataSetResponseBodyDataData> Data { get; set; }
            public class ListDataSetResponseBodyDataData : TeaModel {
                [NameInMap("AutoTranscoding")]
                [Validation(Required=false)]
                public int? AutoTranscoding { get; set; }

                [NameInMap("ChannelId0")]
                [Validation(Required=false)]
                public int? ChannelId0 { get; set; }

                [NameInMap("ChannelId1")]
                [Validation(Required=false)]
                public int? ChannelId1 { get; set; }

                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public int? CreateType { get; set; }

                [NameInMap("DataSetType")]
                [Validation(Required=false)]
                public int? DataSetType { get; set; }

                [NameInMap("IsDelete")]
                [Validation(Required=false)]
                public int? IsDelete { get; set; }

                [NameInMap("RoleConfigProp")]
                [Validation(Required=false)]
                public string RoleConfigProp { get; set; }

                [NameInMap("RoleConfigStatus")]
                [Validation(Required=false)]
                public int? RoleConfigStatus { get; set; }

                [NameInMap("RoleConfigTask")]
                [Validation(Required=false)]
                public string RoleConfigTask { get; set; }

                [NameInMap("SetBucketName")]
                [Validation(Required=false)]
                public string SetBucketName { get; set; }

                [NameInMap("SetDomain")]
                [Validation(Required=false)]
                public string SetDomain { get; set; }

                [NameInMap("SetFolderName")]
                [Validation(Required=false)]
                public string SetFolderName { get; set; }

                [NameInMap("SetId")]
                [Validation(Required=false)]
                public long? SetId { get; set; }

                [NameInMap("SetName")]
                [Validation(Required=false)]
                public string SetName { get; set; }

                [NameInMap("SetNumber")]
                [Validation(Required=false)]
                public int? SetNumber { get; set; }

                [NameInMap("SetRoleArn")]
                [Validation(Required=false)]
                public string SetRoleArn { get; set; }

                [NameInMap("SetType")]
                [Validation(Required=false)]
                public int? SetType { get; set; }

                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public int? SourceDataType { get; set; }

                [NameInMap("SubDir")]
                [Validation(Required=false)]
                public string SubDir { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserGroup")]
                [Validation(Required=false)]
                public string UserGroup { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error details if an error occurs; &quot;successful&quot; on success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public ListDataSetResponseBodyMessages Messages { get; set; }
        public class ListDataSetResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

        }

        /// <summary>
        /// <para>Current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96138D8D-8D26-4E41-BFF4-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Callers can use this field to determine if the request succeeded: true for success; false/null for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
