// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByAppRequest : TeaModel {
        /// <summary>
        /// <para>The name of the API. The name is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>getPersonInfo</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b19240592b1b4e74961fb8438ed7550c</para>
        /// </summary>
        [NameInMap("ApiUid")]
        [Validation(Required=false)]
        public string ApiUid { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333486644</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>The description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request HTTP method of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request path of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/tt</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
