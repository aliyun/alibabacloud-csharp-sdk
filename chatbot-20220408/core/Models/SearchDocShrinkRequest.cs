// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchDocShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("ModifyTimeBegin")]
        [Validation(Required=false)]
        public string ModifyTimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-05-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("ModifyTimeEnd")]
        [Validation(Required=false)]
        public string ModifyTimeEnd { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SearchScope")]
        [Validation(Required=false)]
        public int? SearchScope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-02T03:09:30Z</para>
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-03T03:09:30Z</para>
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public string TagIdsShrink { get; set; }

    }

}
