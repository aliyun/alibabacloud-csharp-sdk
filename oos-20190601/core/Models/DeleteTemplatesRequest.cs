// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the related executions when a template is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoDeleteExecutions")]
        [Validation(Required=false)]
        public bool? AutoDeleteExecutions { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The names of the templates to be deleted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;t1&quot;,&quot;t2&quot;]</para>
        /// </summary>
        [NameInMap("TemplateNames")]
        [Validation(Required=false)]
        public string TemplateNames { get; set; }

    }

}
