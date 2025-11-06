// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeTasksResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeTasksResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeTasksResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeTasksResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public List<ListMdsCubeTasksResponseBodyResultContentDataContent> Content { get; set; }
                public class ListMdsCubeTasksResponseBodyResultContentDataContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>570DA89281533-default</para>
                    /// </summary>
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-10-24 15:17:15</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-10-24 15:17:15</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("GreyConfigInfo")]
                    [Validation(Required=false)]
                    public string GreyConfigInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-10-24 15:17:15</para>
                    /// </summary>
                    [NameInMap("GreyEndtimeData")]
                    [Validation(Required=false)]
                    public string GreyEndtimeData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("GreyNum")]
                    [Validation(Required=false)]
                    public int? GreyNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PublishMode")]
                    [Validation(Required=false)]
                    public int? PublishMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("PublishType")]
                    [Validation(Required=false)]
                    public int? PublishType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0.0.1</para>
                    /// </summary>
                    [NameInMap("ResourceVersion")]
                    [Validation(Required=false)]
                    public string ResourceVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TEST</para>
                    /// </summary>
                    [NameInMap("TaskDesc")]
                    [Validation(Required=false)]
                    public string TaskDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TaskStatus")]
                    [Validation(Required=false)]
                    public int? TaskStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TemplateResourceId")]
                    [Validation(Required=false)]
                    public long? TemplateResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TEST</para>
                    /// </summary>
                    [NameInMap("WhitelistIds")]
                    [Validation(Required=false)]
                    public string WhitelistIds { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
