// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateCallSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-522327189435260928</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Summary information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;summaryTitle&quot;:&quot;标题&quot;,&quot;summaryContent&quot;:&quot;内容&quot;,&quot;keywords&quot;:&quot;关键信息&quot;}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        /// <summary>
        /// <para>Customer ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51e155ce-3747-*****-b402-13c69597b920</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
