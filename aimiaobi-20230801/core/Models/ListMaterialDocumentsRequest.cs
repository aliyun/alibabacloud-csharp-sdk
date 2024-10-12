// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListMaterialDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33a2658aaabf4c24b45d50e575125311_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-18 02:00:00</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-02-19 07:28:11</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jsonLine</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("DocTypeList")]
        [Validation(Required=false)]
        public List<string> DocTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GeneratePublicUrl")]
        [Validation(Required=false)]
        public bool? GeneratePublicUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-18 03:00:00</para>
        /// </summary>
        [NameInMap("UpdateTimeEnd")]
        [Validation(Required=false)]
        public string UpdateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-18 02:00:00</para>
        /// </summary>
        [NameInMap("UpdateTimeStart")]
        [Validation(Required=false)]
        public string UpdateTimeStart { get; set; }

    }

}
