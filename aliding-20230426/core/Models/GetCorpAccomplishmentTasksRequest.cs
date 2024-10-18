// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetCorpAccomplishmentTasksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APP_PBKTxxx</para>
        /// </summary>
        [NameInMap("AppTypes")]
        [Validation(Required=false)]
        public string AppTypes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corpIdxxx</para>
        /// </summary>
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("CreateFromTimeGMT")]
        [Validation(Required=false)]
        public long? CreateFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("CreateToTimeGMT")]
        [Validation(Required=false)]
        public long? CreateToTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>**</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;xx&quot;,&quot;xxx&quot;]</para>
        /// </summary>
        [NameInMap("ProcessCodes")]
        [Validation(Required=false)]
        public string ProcessCodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hexxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
