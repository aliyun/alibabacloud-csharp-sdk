// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchFaqShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If not specified, the default business space is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the category.</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

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
        /// <para>test01</para>
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
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Search title</para>
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
        /// <para>The name of the modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Search titles and similar questions.</description></item>
        /// <item><description>2: Search answers.</description></item>
        /// <item><description>3: Search all.</description></item>
        /// </list>
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
        /// <para>The knowledge status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: deleted and unpublished.</description></item>
        /// <item><description>1: unpublished.</description></item>
        /// <item><description>2: published.</description></item>
        /// <item><description>3: updated and unpublished.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
