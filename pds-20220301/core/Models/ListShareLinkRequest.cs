// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListShareLinkRequest : TeaModel {
        /// <summary>
        /// <para>The creator of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9b7a5aa04d14ae3867fdc886fa01da4</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the shares that are canceled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("include_cancelled")]
        [Validation(Required=false)]
        public bool? IncludeCancelled { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 0 to 100.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Default value: created_at. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>share_name: sorts the results by the name of the share.</description></item>
        /// <item><description>updated_at: sorts the results by the time when the share was modified.</description></item>
        /// <item><description>description: sorts the results by the description of the share.</description></item>
        /// <item><description>created_at: sorts the results by the time when the share was created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share_name</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the returned results. By default, order_direction is set to DESC if order_by is set to created_at or updated_at, and is set to ASC if order_by is set to other values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: sorts the results in ascending order.</description></item>
        /// <item><description>DESC: sorts the results in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

    }

}
