// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class OperateAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public int? AppId { get; set; }

        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The operation type. Supported operations include starting, stopping, and restarting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

    }

}
