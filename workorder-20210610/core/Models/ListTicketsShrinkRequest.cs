// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The end time when the ticket was created. Use this parameter with StartDate to query tickets created within a specific time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1623396736000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search. The keyword is used to match the content of the Description field of the ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time when the ticket was created. Use this parameter with EndDate to query tickets created within a specific time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1623396736000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>A list of ticket statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The ticket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0005PYGCW</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>A list of ticket IDs.</para>
        /// </summary>
        [NameInMap("TicketIdList")]
        [Validation(Required=false)]
        public string TicketIdListShrink { get; set; }

        /// <summary>
        /// <para>The UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1902070573958003</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
