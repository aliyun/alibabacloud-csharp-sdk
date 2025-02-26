// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTaskByParamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
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
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTaskByParamResponseBodyData Data { get; set; }
        public class QueryTaskByParamResponseBodyData : TeaModel {
            [NameInMap("task")]
            [Validation(Required=false)]
            public List<QueryTaskByParamResponseBodyDataTask> Task { get; set; }
            public class QueryTaskByParamResponseBodyDataTask : TeaModel {
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TKP000442-333</para>
                /// </summary>
                [NameInMap("ReceiversName")]
                [Validation(Required=false)]
                public string ReceiversName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public string RequestCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>202201</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1054296</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Short Simple</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1569734892</para>
                /// </summary>
                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
