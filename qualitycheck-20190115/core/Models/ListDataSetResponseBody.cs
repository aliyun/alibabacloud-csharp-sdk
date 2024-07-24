// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListDataSetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AutoTranscoding")]
                [Validation(Required=false)]
                public int? AutoTranscoding { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChannelId0")]
                [Validation(Required=false)]
                public int? ChannelId0 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelId1")]
                [Validation(Required=false)]
                public int? ChannelId1 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-06-20T17:33Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public int? CreateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DataSetType")]
                [Validation(Required=false)]
                public int? DataSetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsDelete")]
                [Validation(Required=false)]
                public int? IsDelete { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>filesFromLocal/ef7ff45c147a4a5e882c925f9a75ac43</para>
                /// </summary>
                [NameInMap("RoleConfigProp")]
                [Validation(Required=false)]
                public string RoleConfigProp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RoleConfigStatus")]
                [Validation(Required=false)]
                public int? RoleConfigStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("RoleConfigTask")]
                [Validation(Required=false)]
                public string RoleConfigTask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SetBucketName")]
                [Validation(Required=false)]
                public string SetBucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SetDomain")]
                [Validation(Required=false)]
                public string SetDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SetFolderName")]
                [Validation(Required=false)]
                public string SetFolderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SetId")]
                [Validation(Required=false)]
                public long? SetId { get; set; }

                [NameInMap("SetName")]
                [Validation(Required=false)]
                public string SetName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SetNumber")]
                [Validation(Required=false)]
                public int? SetNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SetRoleArn")]
                [Validation(Required=false)]
                public string SetRoleArn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SetType")]
                [Validation(Required=false)]
                public int? SetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public int? SourceDataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("SubDir")]
                [Validation(Required=false)]
                public string SubDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-05-10T10:34Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserGroup")]
                [Validation(Required=false)]
                public string UserGroup { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>96138D8D-8D26-4E41-BFF4-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
