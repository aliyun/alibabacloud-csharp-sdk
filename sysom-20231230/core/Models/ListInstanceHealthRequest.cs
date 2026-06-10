// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceHealthRequest : TeaModel {
        /// <summary>
        /// <para>cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2dc6f3be-bf24-4070-8d3a-c03c26850532</para>
        /// </summary>
        [NameInMap("cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>Current page number for paging</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>End Time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725801327754</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public float? End { get; set; }

        /// <summary>
        /// <para>instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz9d00ut2ska3mlyhn6j</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>Page size. Default value is 5. Valid range: [1,100]</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start Time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725797727754</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public float? Start { get; set; }

    }

}
