// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTagByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Data records</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTagByParamResponseBodyData Data { get; set; }
        public class QueryTagByParamResponseBodyData : TeaModel {
            [NameInMap("tag")]
            [Validation(Required=false)]
            public List<QueryTagByParamResponseBodyDataTag> Tag { get; set; }
            public class QueryTagByParamResponseBodyDataTag : TeaModel {
                /// <summary>
                /// <para>Tag description</para>
                /// 
                /// <b>Example:</b>
                /// <para>test description</para>
                /// </summary>
                [NameInMap("TagDescription")]
                [Validation(Required=false)]
                public string TagDescription { get; set; }

                /// <summary>
                /// <para>Tag ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>52366</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>Tag name</para>
                /// 
                /// <b>Example:</b>
                /// <para>hellopal</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

    }

}
