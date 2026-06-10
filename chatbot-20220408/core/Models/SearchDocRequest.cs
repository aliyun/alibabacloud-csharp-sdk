// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchDocRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If omitted, the default workspace is used. You can obtain this key from the Business Management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>A list of category IDs.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<long?> CategoryIds { get; set; }

        /// <summary>
        /// <para>The start of the creation time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the creation time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The name of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <para>The start of the expiration time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the expiration time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>搜索关键字</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The start of the modification time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("ModifyTimeBegin")]
        [Validation(Required=false)]
        public string ModifyTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the modification time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("ModifyTimeEnd")]
        [Validation(Required=false)]
        public string ModifyTimeEnd { get; set; }

        /// <summary>
        /// <para>The name of the last modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The task status.<br>Valid values:<br>• -1: Queued<br>• 0: Succeeded<br>• 1: Parsing<br>• 2: Processing<br>• 3: Failed<br><br><br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// <para>The search scope.<br>Valid values:<br>• 1: Search titles<br>• 2: Search content<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SearchScope")]
        [Validation(Required=false)]
        public int? SearchScope { get; set; }

        /// <summary>
        /// <para>The start of the effective time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the effective time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-03T03:09:30Z</para>
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// <para>The edit status.<br>Valid values:<br>• 1: Unpublished<br>• 2: Published<br>• 3: Updated but not published<br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>A list of tag IDs. If you provide multiple IDs, the operation returns documents that match at least one of the specified tags (logical OR).</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<long?> TagIds { get; set; }

    }

}
