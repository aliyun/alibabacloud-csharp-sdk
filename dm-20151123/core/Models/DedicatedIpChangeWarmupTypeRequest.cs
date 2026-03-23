// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpChangeWarmupTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dedicated IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The prefetch method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sysCusStream</para>
        /// </summary>
        [NameInMap("WarmupType")]
        [Validation(Required=false)]
        public string WarmupType { get; set; }

    }

}
