// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class UpdateEgressProxyIpPoolAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eppool-gw80606a59ecc101****</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolName")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SourceIP</para>
        /// </summary>
        [NameInMap("HashFactor")]
        [Validation(Required=false)]
        public string HashFactor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>X-Forwarded-For</para>
        /// </summary>
        [NameInMap("HashHeaderName")]
        [Validation(Required=false)]
        public string HashHeaderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

    }

}
