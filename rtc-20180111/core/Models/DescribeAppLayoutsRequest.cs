// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppLayoutsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Create and query it using the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public DescribeAppLayoutsRequestCondition Condition { get; set; }
        public class DescribeAppLayoutsRequestCondition : TeaModel {
            /// <summary>
            /// <para>The layout ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167466539798442****</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>The layout name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
