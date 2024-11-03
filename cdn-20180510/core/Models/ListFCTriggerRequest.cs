// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event. You can specify only one name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogFileCreated</para>
        /// </summary>
        [NameInMap("EventMetaName")]
        [Validation(Required=false)]
        public string EventMetaName { get; set; }

        /// <summary>
        /// <para>The version number of the event. You can specify only one version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("EventMetaVersion")]
        [Validation(Required=false)]
        public string EventMetaVersion { get; set; }

    }

}
