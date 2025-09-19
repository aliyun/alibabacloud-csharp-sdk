// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVersionPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum amount of data to be read in this call, with a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>用来表示当前调用返回读取到的位置。空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Number of items per page, with a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeVersionPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeVersionPageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Change content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;description\&quot;:\&quot;自定义变量\&quot;,\&quot;expression\&quot;:\&quot;1\&quot;,\&quot;expressionTitle\&quot;:\&quot;1\&quot;,\&quot;expressionVariable\&quot;:\&quot;\&quot;,\&quot;fieldRank\&quot;:0,\&quot;id\&quot;:392023,\&quot;name\&quot;:\&quot;ex_OERlw0Zqfb23\&quot;,\&quot;outlier\&quot;:\&quot;SYS_ERROR\&quot;,\&quot;outputs\&quot;:\&quot;STRING\&quot;,\&quot;refObjId\&quot;:\&quot;de_auevox0336\&quot;,\&quot;region\&quot;:\&quot;SH\&quot;,\&quot;title\&quot;:\&quot;自定义变量\&quot;,\&quot;version\&quot;:4}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Variable description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>变量描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Primary key ID of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>808</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>Name of the variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex_OERlw0Zqfb23</para>
            /// </summary>
            [NameInMap("objectCode")]
            [Validation(Required=false)]
            public string ObjectCode { get; set; }

            /// <summary>
            /// <para>Primary key ID of the variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>392023</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public long? ObjectId { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Variable type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXPRESSION</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151222222222226</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>Version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
