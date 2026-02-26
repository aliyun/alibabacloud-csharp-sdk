// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetSavedQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D98D9B0-318D-56A4-910C-93B5F945AF2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the template.</para>
        /// </summary>
        [NameInMap("SavedQuery")]
        [Validation(Required=false)]
        public GetSavedQueryResponseBodySavedQuery SavedQuery { get; set; }
        public class GetSavedQueryResponseBodySavedQuery : TeaModel {
            /// <summary>
            /// <para>The time when the template was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-30T01:43:16Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>查询我的所有资源，返回所有的列。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expression of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM resources;</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>查询我的所有资源。</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cq-GeAck****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <para>The time when the template was last updated. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-30T01:43:16Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
