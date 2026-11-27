// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppViewTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0A2FCBC-43A4-428F-BC1D-3F4F85837F76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Template list</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeAppViewTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeAppViewTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>Creation time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-04T06:22:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>List of layout IDs</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>Encoding option</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>Template name</para>
            /// 
            /// <b>Example:</b>
            /// <para>模板名称</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bj6D****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
