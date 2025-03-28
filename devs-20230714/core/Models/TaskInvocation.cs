// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskInvocation : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-nkj8shz7xxxx</para>
        /// </summary>
        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E099843B-10A2-4936-9964-4E0EE263D564</para>
        /// </summary>
        [NameInMap("invocationID")]
        [Validation(Required=false)]
        public string InvocationID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-hangzhou:143xxxx:services/xxx.LATEST/functions/xxx</para>
        /// </summary>
        [NameInMap("invocationTarget")]
        [Validation(Required=false)]
        public string InvocationTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B3058B1-F1C9-457C-B95C-2C250A4B3118</para>
        /// </summary>
        [NameInMap("requestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-sls-logstore</para>
        /// </summary>
        [NameInMap("slsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-sls-project</para>
        /// </summary>
        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
