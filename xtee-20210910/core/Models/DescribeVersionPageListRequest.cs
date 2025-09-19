// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVersionPageListRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for the request and response messages, with a default value of <b>zh</b>. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Maximum number of results to be read in this call, with a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Used to mark the starting position for reading. An empty value indicates starting from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>Number of items per page, with a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Pagination flag, with a default value of true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("paging")]
        [Validation(Required=false)]
        public bool? Paging { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPRESSION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
