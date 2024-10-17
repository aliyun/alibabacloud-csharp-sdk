// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-09 11:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The scope of the tickets that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AS_ADMIN</b>: all tickets.</description></item>
        /// <item><description><b>AS_COMMITTER</b>: the tickets that are submitted by the current user.</description></item>
        /// <item><description><b>AS_HANDLER</b>: the tickets to be processed by the current user.</description></item>
        /// <item><description><b>AS_OWNER</b>: the tickets that are processed by the current user.</description></item>
        /// <item><description><b>AS_Related</b>: the tickets that are related to the current user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AS_ADMIN</para>
        /// </summary>
        [NameInMap("OrderResultType")]
        [Validation(Required=false)]
        public string OrderResultType { get; set; }

        /// <summary>
        /// <para>The status of the tickets that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: queries the tickets of all statuses.</description></item>
        /// <item><description><b>FINISHED</b>: queries the tickets that are completed.</description></item>
        /// <item><description><b>RUNNING</b>: queries the tickets that are being processed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
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
        /// <para>The type of the tickets that you want to query. For more information, see <a href="https://help.aliyun.com/document_detail/429109.html">PluginType parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC_COMMON</para>
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// <para>The keyword that is used to query tickets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchContent")]
        [Validation(Required=false)]
        public string SearchContent { get; set; }

        /// <summary>
        /// <para>The time condition based on which you want to query tickets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATE_TIME</b>: the time when a ticket was created.</description></item>
        /// <item><description><b>MODIFY_TIME</b>: the time when a ticket was last modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_TIME</para>
        /// </summary>
        [NameInMap("SearchDateType")]
        [Validation(Required=false)]
        public string SearchDateType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-08 11:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
