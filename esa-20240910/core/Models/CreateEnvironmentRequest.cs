// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The environment name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NPDcP1</para>
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// <para>The name of the environment with the next priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认环境</para>
        /// </summary>
        [NameInMap("NextEnvironmentName")]
        [Validation(Required=false)]
        public string NextEnvironmentName { get; set; }

        /// <summary>
        /// <para>The environment rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(&quot;ip&quot; eq &quot;1.1.1.1&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123**</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
