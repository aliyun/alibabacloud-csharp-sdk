// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAuditHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting rule of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b>: sorts the results based on the creation time in descending order. This is the default value.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: sorts the results based on the creation time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the video.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f44*****6e91d24d81d4</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
