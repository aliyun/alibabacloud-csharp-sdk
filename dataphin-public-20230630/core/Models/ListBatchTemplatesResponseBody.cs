// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBatchTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListBatchTemplatesResponseBodyPageResult PageResult { get; set; }
        public class ListBatchTemplatesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of template records.</para>
            /// </summary>
            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public List<ListBatchTemplatesResponseBodyPageResultTemplateList> TemplateList { get; set; }
            public class ListBatchTemplatesResponseBodyPageResultTemplateList : TeaModel {
                /// <summary>
                /// <para>The template submission comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>初始化提交</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The template content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash
                /// echo \&quot;hello world\&quot;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The current latest version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The template description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用于数据处理的Shell模板</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The compute engine version. Currently supported Python versions: Python 2.7 and Python 3.7.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Python 3.7</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The template creation time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The template update time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-28 15:30:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The template ID, which is the same as the menu tree node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The last modifier of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The ID of the last modifier of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100002</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>数据处理模板</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node type. Valid values: 10 (Shell) and 21 (Python).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OperatorType")]
                [Validation(Required=false)]
                public int? OperatorType { get; set; }

                /// <summary>
                /// <para>The template owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The template owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The template status. Valid values: 0 (draft), 2 (submitted), and 100 (in development).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
