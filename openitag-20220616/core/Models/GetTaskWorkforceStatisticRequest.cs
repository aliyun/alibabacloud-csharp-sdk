// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class GetTaskWorkforceStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the member list. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of members per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The statistics type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ITEM: Statistics are collected based on individual review records.</description></item>
        /// <item><description>OPERATORCELL: Statistics are collected based on operation units. A single ITEM may contain multiple operation units.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ITEM</para>
        /// </summary>
        [NameInMap("StatType")]
        [Validation(Required=false)]
        public string StatType { get; set; }

    }

}
