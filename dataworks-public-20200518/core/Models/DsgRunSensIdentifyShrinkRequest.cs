// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgRunSensIdentifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of parameter objects for metadata scanning.</para>
        /// </summary>
        [NameInMap("EsMetaParams")]
        [Validation(Required=false)]
        public string EsMetaParamsShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the current username in the upper-right corner, and choose Menu &gt; User Information to obtain the tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
