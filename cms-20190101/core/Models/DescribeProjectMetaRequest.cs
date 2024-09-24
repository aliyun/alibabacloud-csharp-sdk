// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProjectMetaRequest : TeaModel {
        /// <summary>
        /// <para>The tags. Tags are used to filter services.</para>
        /// <para>You can filter services only by the tag whose <c>name</c> is <c>product</c>. Example: {&quot;name&quot;:&quot;product&quot;,&quot;value&quot;:&quot;ECS&quot;}.</para>
        /// <remarks>
        /// <para>We recommend that you do not use the special tags in the CloudMonitor console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;product&quot;,&quot;value&quot;:&quot;ECS&quot;}]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 10000.</para>
        /// <para>Default value: 30.</para>
        /// <remarks>
        /// <para>The value of this parameter is not limited. You can view a large number of entries per page.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
