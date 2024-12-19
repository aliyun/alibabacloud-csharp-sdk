// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies to create a service-linked role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreateSlr")]
        [Validation(Required=false)]
        public bool? CreateSlr { get; set; }

        /// <summary>
        /// <para>The log type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROVIDER</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROVIDER</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>slslogstore</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-gateway</para>
        /// </summary>
        [NameInMap("SlsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rec-lq-sls</para>
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

    }

}
