// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ImportNameListRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for request and response messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Import name list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa\nbb\ncc</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Document import type:</para>
        /// <para>INPUT: Text input
        /// CSV: CSV upload
        /// NONE: Do not upload for now</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSV</para>
        /// </summary>
        [NameInMap("importType")]
        [Validation(Required=false)]
        public string ImportType { get; set; }

        /// <summary>
        /// <para>name content memo</para>
        /// 
        /// <b>Example:</b>
        /// <para>名单内容描述</para>
        /// </summary>
        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>nameListType</para>
        /// 
        /// <b>Example:</b>
        /// <para>accountId</para>
        /// </summary>
        [NameInMap("nameListType")]
        [Validation(Required=false)]
        public string NameListType { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>变量title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Variable ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>393314</para>
        /// </summary>
        [NameInMap("variableId")]
        [Validation(Required=false)]
        public long? VariableId { get; set; }

    }

}
