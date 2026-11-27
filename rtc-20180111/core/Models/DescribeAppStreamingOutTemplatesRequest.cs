// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppStreamingOutTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>Application ID, created and queried through the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ioeh****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Search condition.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public DescribeAppStreamingOutTemplatesRequestCondition Condition { get; set; }
        public class DescribeAppStreamingOutTemplatesRequestCondition : TeaModel {
            /// <summary>
            /// <para>Template Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bj6D****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Page number. By default, page 1 is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of entries per page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
