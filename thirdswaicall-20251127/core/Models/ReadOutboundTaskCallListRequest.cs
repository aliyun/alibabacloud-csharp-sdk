// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ThirdswAicall20251127.Models
{
    public class ReadOutboundTaskCallListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张先生</para>
        /// </summary>
        [NameInMap("CustomerNameOrPhone")]
        [Validation(Required=false)]
        public string CustomerNameOrPhone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;, &quot;2&quot;]</para>
        /// </summary>
        [NameInMap("DisplayStatusList")]
        [Validation(Required=false)]
        public List<string> DisplayStatusList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;有意向&quot;, &quot;高净值&quot;]</para>
        /// </summary>
        [NameInMap("LabelTags")]
        [Validation(Required=false)]
        public List<string> LabelTags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>nextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>51CC272E-D879-1B23-B98E-FCFB072D362B</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
