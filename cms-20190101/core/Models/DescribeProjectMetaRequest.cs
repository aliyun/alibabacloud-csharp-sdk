// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProjectMetaRequest : TeaModel {
        /// <summary>
        /// <para>The tags. Tags are used to filter alerts, and each alert can be marked with special tags.</para>
        /// <para>Currently, only filtering by product is supported. That is, the <c>name</c> is <c>product</c>. For example: {&quot;name&quot;:&quot;product&quot;,&quot;value&quot;:&quot;ECS&quot;}.</para>
        /// <remarks>
        /// <para>We do not recommend that you use the special tags for the CloudMonitor console in Alibaba Cloud.</para>
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
        /// <para>Currently, Alibaba Cloud does not impose a limit on this parameter. If you need to obtain all results, set the page size to a large value.</para>
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
