// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListMaterialDocumentsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33a2658aaabf4c24b45d50e575125311_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Full-text search of document content</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Creation time - end range. Format: yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-18 02:00:00</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>Creation time - start range. Format: yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-19 07:28:11</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>Document type (html: web page, plainText: plain text, image: image, pdf: pdf, word: word, excel: excel, csv: csv, jsonLine: jsonLine)</para>
        /// 
        /// <b>Example:</b>
        /// <para>jsonLine</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Document type list (html: web page, plainText: plain text, image: image, pdf: pdf, word: word, excel: excel, csv: csv, jsonLine: jsonLine)</para>
        /// 
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("DocTypeList")]
        [Validation(Required=false)]
        public string DocTypeListShrink { get; set; }

        /// <summary>
        /// <para>Generate a public URL for the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GeneratePublicUrl")]
        [Validation(Required=false)]
        public bool? GeneratePublicUrl { get; set; }

        /// <summary>
        /// <para>Material primary key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Document keywords.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string KeywordsShrink { get; set; }

        /// <summary>
        /// <para>Supports comprehensive queries for title, content, and content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小猫</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Share property: 0: personal private, 1: shared within the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        /// <summary>
        /// <para>Number of items per page. Default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Performs a full-text search on material titles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新闻标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Update time - end range. Format: yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-18 03:00:00</para>
        /// </summary>
        [NameInMap("UpdateTimeEnd")]
        [Validation(Required=false)]
        public string UpdateTimeEnd { get; set; }

        /// <summary>
        /// <para>Update time - start range. Format: yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-18 02:00:00</para>
        /// </summary>
        [NameInMap("UpdateTimeStart")]
        [Validation(Required=false)]
        public string UpdateTimeStart { get; set; }

    }

}
