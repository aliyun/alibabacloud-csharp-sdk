// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteJobTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the job templates that you want to delete. You can specify a maximum of 20 job template IDs.</para>
        /// <para>Format of job template IDs: <c>[{&quot;Id&quot;: &quot;0.sched****&quot;},{&quot;Id&quot;: &quot;1.sched****&quot;}]</c>. Separate multiple job template IDs with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87248.html">ListJobTemplates</a> operation to query job template IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Id&quot;:&quot;ehpc-job-tmpl-6RVcMK****&quot;},{&quot;Id&quot;: &quot;ehpc-job-tmpl-6RxO5y****&quot;}]</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public string Templates { get; set; }

    }

}
