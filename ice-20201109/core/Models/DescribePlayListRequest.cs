// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676170500011</para>
        /// </summary>
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public string BeginTs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682474405173</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FirstFrameDuration</para>
        /// </summary>
        [NameInMap("OrderName")]
        [Validation(Required=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vod</para>
        /// </summary>
        [NameInMap("PlayType")]
        [Validation(Required=false)]
        public string PlayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5e70516766285805381012d271e</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
